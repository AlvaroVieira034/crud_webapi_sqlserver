using WebApiBase.Models;

namespace WebApiBase.Services.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int Id);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editarFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int Id);
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int Id);

    }  

}
