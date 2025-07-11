namespace SistemaAcademico.Repositorios
{
    public interface IRepositorio<T> where T : class
    {
        List<T> ObtenerTodos();
        T? BuscarPorId(int id);
        void Agregar(T entidad);
        void Editar(T entidad);
        void EliminarPorId(int id);
    }
}
