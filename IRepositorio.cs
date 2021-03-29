using System.Collections.cs;

namespace IRepositorioSerie
{
    public interface IRepositorio<Serie>
    {
        List<Serie> Lista();
        T RetornaPorId(int id);
        void Inserir (T entidade);
        void Excluir (int id);
        void Atualizar (int id);
        int ProximoId();
    }
}
