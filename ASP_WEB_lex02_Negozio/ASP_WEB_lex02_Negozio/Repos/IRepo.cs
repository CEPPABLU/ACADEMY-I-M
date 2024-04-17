namespace ASP_WEB_lex02_Negozio.Repos
{
    public interface IRepo<T>
    {
        bool insert (T t);

        T? GetById(int id);
        List<T> GetAll();
        bool Delete(int id);
        bool Update(T t);  
    }
}
