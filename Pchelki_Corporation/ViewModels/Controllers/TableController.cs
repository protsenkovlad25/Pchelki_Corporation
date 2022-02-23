using Microsoft.EntityFrameworkCore;
using Pchelki_Corporation.Models.Entityes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchelki_Corporation.ViewModels
{
    class TableController : Base.BaseViewModels
    {
        private readonly PchelkiContext context;

        #region ObservableCollection
        public ObservableCollection<Bee_Garden> Bee_Gardens { get; set; }
        public ObservableCollection<Client> Clients { get; set; }
        public ObservableCollection<Disease> Diseases { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }
        public ObservableCollection<Equipment> Equipments { get; set; }
        public ObservableCollection<Family> Families { get; set; }
        public ObservableCollection<Healing> Healings { get; set; }
        public ObservableCollection<Post> Posts { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Product_Sold> Product_Solds { get; set; }
        public ObservableCollection<Room> Rooms { get; set; }
        public ObservableCollection<Sale> Sales { get; set; }
        public ObservableCollection<Sign> Signs { get; set; }
        public ObservableCollection<Tabel> Tabels { get; set; }
        public ObservableCollection<Type_of_Beehives> Types_of_Beehives { get; set; }
        public ObservableCollection<Type_of_Bees> Types_of_Bees { get; set; }
        public ObservableCollection<Type_of_Work> Types_of_Work { get; set; }
        public ObservableCollection<Work> Works { get; set; }
        public ObservableCollection<Employee_by_Post> Employees_by_Posts { get; set; }
        public ObservableCollection<Healing_of_Disease> Healings_of_Diseases { get; set; }
        public ObservableCollection<Sick> Sicks { get; set; }
        public ObservableCollection<Sign_of_Disease> Signs_of_Diseases { get; set; }
        #endregion

        public TableController()
        {
            context = new PchelkiContext();

            #region Entities
            Bee_Gardens = new ObservableCollection<Bee_Garden>(context.Bee_Gardens);

            Clients = new ObservableCollection<Client>(context.Clients);

            Diseases = new ObservableCollection<Disease>(context.Diseases);

            Employees = new ObservableCollection<Employee>(context.Employees);

            Equipments = new ObservableCollection<Equipment>(context.Equipments);

            Families = new ObservableCollection<Family>(context.Families.Include(s => s.Type_of_Bees));
            Families = new ObservableCollection<Family>(context.Families.Include(s => s.Type_of_Beehives));
            Families = new ObservableCollection<Family>(context.Families.Include(s => s.Bee_Garden));

            Healings = new ObservableCollection<Healing>(context.Healings);

            Posts = new ObservableCollection<Post>(context.Posts);

            Products = new ObservableCollection<Product>(context.Products);

            Product_Solds = new ObservableCollection<Product_Sold>(context.Product_Solds.Include(s => s.Product));
            Product_Solds = new ObservableCollection<Product_Sold>(context.Product_Solds.Include(s => s.Sale));

            Rooms = new ObservableCollection<Room>(context.Rooms);

            Sales = new ObservableCollection<Sale>(context.Sales.Include(s => s.Client));
            Sales = new ObservableCollection<Sale>(context.Sales.Include(s => s.Employee));

            Signs = new ObservableCollection<Sign>(context.Signs);

            Tabels = new ObservableCollection<Tabel>(context.Tabels.Include(s => s.Family));
            Tabels = new ObservableCollection<Tabel>(context.Tabels.Include(s => s.Equipment));
            Tabels = new ObservableCollection<Tabel>(context.Tabels.Include(s => s.Employee));
            Tabels = new ObservableCollection<Tabel>(context.Tabels.Include(s => s.Product));
            Tabels = new ObservableCollection<Tabel>(context.Tabels.Include(s => s.Room));
            Tabels = new ObservableCollection<Tabel>(context.Tabels.Include(s => s.Work));

            Types_of_Beehives = new ObservableCollection<Type_of_Beehives>(context.Types_of_Beehives);

            Types_of_Bees = new ObservableCollection<Type_of_Bees>(context.Types_of_Bees);

            Types_of_Work = new ObservableCollection<Type_of_Work>(context.Types_of_Work);

            Works = new ObservableCollection<Work>(context.Works);

            Employees_by_Posts = new ObservableCollection<Employee_by_Post>(context.Employees_by_Posts.Include(s => s.Employee));
            Employees_by_Posts = new ObservableCollection<Employee_by_Post>(context.Employees_by_Posts.Include(s => s.Post));

            Healings_of_Diseases = new ObservableCollection<Healing_of_Disease>(context.Healings_of_Diseases.Include(s => s.Healing));
            Healings_of_Diseases = new ObservableCollection<Healing_of_Disease>(context.Healings_of_Diseases.Include(s => s.Disease));

            Sicks = new ObservableCollection<Sick>(context.Sicks.Include(s => s.Family));
            Sicks = new ObservableCollection<Sick>(context.Sicks.Include(s => s.Disease));

            Signs_of_Diseases = new ObservableCollection<Sign_of_Disease>(context.Signs_of_Diseases.Include(s => s.Sign));
            Signs_of_Diseases = new ObservableCollection<Sign_of_Disease>(context.Signs_of_Diseases.Include(s => s.Disease));
            #endregion
        }
    }
}
