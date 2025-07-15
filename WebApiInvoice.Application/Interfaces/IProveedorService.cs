using System.Collections.Generic;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoice.Application.Interfaces
{
    public interface IProveedorService
    {
        bool Add(Proveedor model);
        bool Delete(int id);
        List<Proveedor> SelectAll();
        Proveedor SelectById(int id);
        bool Update(Proveedor model);
    }
}