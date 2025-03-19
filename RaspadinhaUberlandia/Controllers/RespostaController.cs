using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaspadinhaDigital.API.Models;

namespace RaspadinhaDigital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // Cadastro de usuário
        [HttpPost("registrarUsuario")]
        public async Task<IActionResult> Cadastro([FromBody] RegistroUsuario userRegistration)
        {
            var result = await _userService.RegistroUsuario(userRegistration);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Login de usuário
        [HttpPost("loginUsuario")]
        public async Task<IActionResult> Login([FromBody] UsuarioAcesso userLogin)
        {
            var result = await _userService.UsuarioAcesso(userLogin);
            if (result.IsSuccess)
                return Ok(result);
            return Unauthorized(result.ErrorMessage);
        }

        // Cadastro de empresa
        [HttpPost("registrarEmpresa")]
        public async Task<IActionResult> Empresa([FromBody] RegistroEmpresa userRegistrationEmp)
        {
            var result = await _userService.RegistroEmpresa(userRegistrationEmp);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Login de empresa
        [HttpPost("loginEmpresa")]
        public async Task<IActionResult> LoginEmpresa([FromBody] EmpresaAcesso userLogin)
        {
            var result = await _userService.EmpresaAcesso(userLogin);
            if (result.IsSuccess)
                return Ok(result);
            return Unauthorized(result.ErrorMessage);
        }

        // Recuperação de senha
        [HttpPost("recuperarSenha")]
        public async Task<IActionResult> RecoverPassword([FromBody] RecuperarSenha recoveryDto)
        {
            var result = await _userService.RecoverPassword(recoveryDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        public interface IUserService
        {
            Task<Result> RegistroUsuario(RegistroUsuario userRegistration);
            Task<Result> UsuarioAcesso(UsuarioAcesso usuarioLogin);
            Task<Result> RecoverPassword(RecuperarSenha recuperarDto);
            Task<Result> EmpresaAcesso(EmpresaAcesso empresaLogin);
            Task<Result> RegistroEmpresa(RegistroEmpresa userRegistrationEmp);
        }

        public class Result
        {
            public bool IsSuccess { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}
