using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoRepo
{
    public class CupcakeRepo
    {

        private List<Cupcake> _listCupcake = new List<Cupcake>();
        //CRUD Create, Read, Update, Delete

        //Create
        public void AddCupcake(Cupcake cupcake)
        {
            _listCupcake.Add(cupcake);

        }
        //Read
        public List<Cupcake> ShowCupcakes()
        {
            return _listCupcake;
        }
        //Update
        public void UpdateList()
        {

        }
        //Delete
        public void DeleteCupcake()
        {

        }
        //Helper Method
        public Cupcake GetCupcakebyId()
        {
            return null;
        }
    }
}
