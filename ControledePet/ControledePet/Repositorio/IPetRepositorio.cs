using ControledePet.Models;

namespace ControledePet.PetRepositorio
{
    public interface IPetRepositorio
    {
        PetModel ListarPorId(int id);
        List<PetModel> BuscarTodos();
        PetModel Adicionar(PetModel pet);
        PetModel Atualizar(PetModel pet);
        bool Apagar(int id);
    }
}
