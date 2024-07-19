using EstudoFull.Models.Context;
using EstudoFull.Models;
using EstudoFull.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EstudoFull.Repository
{
    public class AllRepository<T> : IAllRepository<T> where T : Base
    {
        public MySQLContext _mySQLcontext;
        private DbSet<T> dataset;

        public AllRepository(MySQLContext mySQLContext)
        {
            _mySQLcontext = mySQLContext;
            dataset = _mySQLcontext.Set<T>();
        }

        public T Atualizar(T pObjeto)
        {
            try
            {
                var oObjeto = BuscarPorId(pObjeto.Id);
                if (oObjeto != null)
                {
                    dataset.Entry(oObjeto).CurrentValues.SetValues(oObjeto);
                    _mySQLcontext.SaveChanges();

                    return oObjeto;
                }
                else
                {
                    return Criar(pObjeto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T BuscarPorId(long pId)
        {
            try
            {
                var oObjeto = dataset.FirstOrDefault(p => p.Id.Equals(pId));
                if (oObjeto != null)
                {
                    return oObjeto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }

        public T Criar(T pObjeto)
        {
            try
            {
                dataset.Add(pObjeto);
                _mySQLcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pObjeto;
        }

        public bool Deletar(long pId)
        {
            try
            {
                var oObjeto = BuscarPorId(pId);
                if (oObjeto != null)
                {
                    dataset.Remove(oObjeto);
                    var result = _mySQLcontext.SaveChanges();

                    return Convert.ToBoolean(result);
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<T> Listar()
        {
            return dataset.ToList();
        }
    }
}
