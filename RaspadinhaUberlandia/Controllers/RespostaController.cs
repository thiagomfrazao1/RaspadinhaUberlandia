using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaspadinhaUberlandia.Entidades;
using RaspadinhaUberlandia.Entidades.CadtAcess;

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

        // Recuperação de senha Usuario
        [HttpPost("recuperarSenhaUsuario")]
        public async Task<IActionResult> RecoverPasswordUsuario([FromBody] RecuperarSenhaUsuario recoveryDtoUsuario)
        {
            var result = await _userService.RecoverPasswordUsuario(recoveryDtoUsuario);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Atualizar dados do usuário
        [HttpPut("atualizarUsuario")]
        public async Task<IActionResult> AtualizarUsuario([FromBody] AtualizarUsuario atualizarUsuario)
        {
            var result = await _userService.AtualizarUsuario(atualizarUsuario);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Solicitar exclusão do usuário (necessário CPF, telefone)
        [HttpPost("solicitarExclusaoUsuario")]
        public async Task<IActionResult> SolicitarExclusaoUsuario([FromBody] ExcluirUsuario request)
        {
            var result = await _userService.SolicitarExclusaoUsuario(request);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Confirmar exclusão do usuário com o código
        [HttpDelete("confirmarExclusaoUsuario")]
        public async Task<IActionResult> ConfirmarExclusaoUsuario([FromBody] ConfirmarExclusaoUsuario request)
        {
            var result = await _userService.ConfirmarExclusaoUsuario(request);
            if (result.IsSuccess)
                return Ok(new { message = "Usuário excluído com sucesso!" });
            return BadRequest(result.ErrorMessage);
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

        // Recuperação de senha Empresa
        [HttpPost("recuperarSenhaEmpresa")]
        public async Task<IActionResult> RecoverPasswordEmpresa([FromBody] RecuperarSenhaEmpresa recoveryDtoEmpresa)
        {
            var result = await _userService.RecoverPasswordEmpresa(recoveryDtoEmpresa);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Atualizar dados da empresa
        [HttpPut("atualizarEmpresa")]
        public async Task<IActionResult> AtualizarEmpresa([FromBody] AtualizarEmpresa atualizarEmpresa)
        {
            var result = await _userService.AtualizarEmpresa(atualizarEmpresa);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Solicitar exclusão da empresa (necessário CNPJ, telefone)
        [HttpPost("solicitarExclusaoEmpresa")]
        public async Task<IActionResult> SolicitarExclusaoEmpresa([FromBody] ExcluirEmpresa request)
        {
            var result = await _userService.SolicitarExclusaoEmpresa(request);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.ErrorMessage);
        }

        // Confirmar exclusão da empresa com o código
        [HttpDelete("confirmarExclusaoEmpresa")]
        public async Task<IActionResult> ConfirmarExclusaoEmpresa([FromBody] ConfirmarExclusaoEmpresa request)
        {
            var result = await _userService.ConfirmarExclusaoEmpresa(request);
            if (result.IsSuccess)
                return Ok(new { message = "Empresa excluída com sucesso!" });
            return BadRequest(result.ErrorMessage);
        }




        public interface IUserService
        {
            // Usuário
            Task<Result> RegistroUsuario(RegistroUsuario userRegistration);
            Task<Result> UsuarioAcesso(UsuarioAcesso usuarioLogin);
            Task<Result> AtualizarUsuario(AtualizarUsuario atualizarUsuario);
            Task<Result> SolicitarExclusaoUsuario(ExcluirUsuario request);
            Task<Result> ConfirmarExclusaoUsuario(ConfirmarExclusaoUsuario request);
            Task<Result> RecoverPasswordUsuario(RecuperarSenhaUsuario recuperarDtoUsuario);


            // Empresa
            Task<Result> RegistroEmpresa(RegistroEmpresa userRegistrationEmp);
            Task<Result> EmpresaAcesso(EmpresaAcesso empresaLogin);
            Task<Result> AtualizarEmpresa(AtualizarEmpresa atualizarEmpresa); 
            Task<Result> SolicitarExclusaoEmpresa(ExcluirEmpresa request);
            Task<Result> ConfirmarExclusaoEmpresa(ConfirmarExclusaoEmpresa request);
            Task<Result> RecoverPasswordEmpresa(RecuperarSenhaEmpresa recuperarDto);
        }

        public class Result
        {
            public bool IsSuccess { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}
