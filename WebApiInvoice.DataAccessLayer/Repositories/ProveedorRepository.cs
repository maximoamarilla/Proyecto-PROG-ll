using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using WebApiInvoice.Domain.Interfaces;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoice.DataAccessLayer
{
    public class ProveedorRepository : IProveedorRepository
    {
        static List<Proveedor> _proveedorList = new List<Proveedor>();
        static int autoincremento = 0;
        public int Create(Proveedor model)
        {

            model.Id = ++autoincremento;
            _proveedorList.Add(model);
            return 1;
        }

        public int Delete(int id)
        {
            Proveedor prv = _proveedorList.Find( p => p.Id == id);

            if (prv != null)
            {
                _proveedorList.Remove(prv);
                return 1;
            }

            return 0;
        }

        public List<Proveedor> Get(int offset = 0, int limit = 0)
        {
            return _proveedorList.FindAll(p => true);
        }

        public Proveedor GetById(int id)
        {
            return _proveedorList.SingleOrDefault( p=> p.Id == id);
        }
        

        public int Update(Proveedor model, int id)
        {
            Proveedor prv = _proveedorList.Find(p => p.Id == id);

            if ( prv != null )
            {
                prv.Name = model.Name;
                prv.Ciudad = model.Ciudad;
                prv.Telefono = model.Telefono;
                prv.CodigoPostal = model.CodigoPostal;
                

                return 1;
            }
            return 0;
        }
    }
}