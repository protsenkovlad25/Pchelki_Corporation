using Pchelki_Corporation.Models.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Pchelki_Corporation.View;

namespace Pchelki_Corporation.ViewModels.Controllers
{
    class AddController: Base.BaseViewModels
    {
        private readonly PchelkiContext context;

        public AddController()
        {
            context = new PchelkiContext();

            CreateProduct = new RelayCommand(obj =>
            {
                Product newProduct = new() { Name = PName };
                ObservableCollection<Product> Product = new ObservableCollection<Product> (context.Products);

                if ((context.Add(newProduct)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newProduct}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newProduct}\" не удалось сохранить в Базу.");

                newProduct = null;
                PName = null;
            });

            #region CreateEmployee
            PostName = new ObservableCollection<string>(context.Posts.Select(x => x.Name));
            CreateEmployee = new RelayCommand(obj =>
            {
                Employee newEmployee = new()
                {
                    Second_Name = ESecondName,
                    First_Name = EFirstName,
                    Father_Name = EFatherName,
                    Date_of_Birth = EDateBirth,
                    Phone_Number = EPhoneNumber,
                    Email = EEmail,
                    Town = ETown,
                    Street = EStreet,
                    Home = EHome
                };
                ObservableCollection<Employee> Employee = new ObservableCollection<Employee>(context.Employees);

                if ((context.Add(newEmployee)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newEmployee}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newEmployee}\" не удалось сохранить в Базу.");

                Employee_by_Post newEmployeePost = new()
                {
                    PostId = context.Posts.Where(x => x.Name == EPost).FirstOrDefault().Id,
                    EmployeeId = context.Employees.Where(x => x.Email == EEmail).FirstOrDefault().Id
                };
                ObservableCollection<Employee_by_Post> EmployeePost = new ObservableCollection<Employee_by_Post>(context.Employees_by_Posts);

                if ((context.Add(newEmployeePost)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newEmployeePost}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newEmployeePost}\" не удалось сохранить в Базу.");

                newEmployee = null;
                newEmployeePost = null;
                ESecondName = null;
                EFirstName = null;
                EFatherName = null;
                EDateBirth = default;
                EPhoneNumber = null;
                EEmail = null;
                ETown = null;
                EStreet = null;
                EHome = 0;
                EPost = null;
            });
            #endregion

            CreatePost = new RelayCommand(obj =>
            {
                Post newPost = new()
                {
                    Name = PoName,
                    Salary = PoSalary
                };
                ObservableCollection<Post> Post = new ObservableCollection<Post>(context.Posts);

                if ((context.Add(newPost)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newPost}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newPost}\" не удалось сохранить в Базу.");

                newPost = null;
                PoName = null;
                PoSalary = 0;
            });

            CreateBeeGarden = new RelayCommand(obj =>
            {
                Bee_Garden newBeeGarden = new()
                {
                    Name = BName,
                    Town = BTown,
                    Street = BStreet,
                    Home = BHome,
                    Square = BSquare
                };
                ObservableCollection<Bee_Garden> BeeGarden = new ObservableCollection<Bee_Garden>(context.Bee_Gardens);

                if ((context.Add(newBeeGarden)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newBeeGarden}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newBeeGarden}\" не удалось сохранить в Базу.");

                newBeeGarden = null;
                BName = null;
                BTown = null;
                BStreet = null;
                BHome = 0;
                BSquare = null;
            });

            CreateTypeBee = new RelayCommand(obj =>
            {
                Type_of_Bees newTypeBee = new()
                {
                    Name = TbName,
                    Productivity_of_Bees = TbProductivity
                };
                ObservableCollection<Type_of_Bees> TypeBee = new ObservableCollection<Type_of_Bees>(context.Types_of_Bees);

                if ((context.Add(newTypeBee)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newTypeBee}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newTypeBee}\" не удалось сохранить в Базу.");

                newTypeBee = null;
                TbName = null;
                TbProductivity = 0;
            });

            CreateTypeBeehive = new RelayCommand(obj =>
            {
                Type_of_Beehives newTypeBeehive = new()
                {
                    Name = TbhName,
                    Size_Beehive = TbhSizeBeehive,
                    Size_Frame = TbhSizeFrame,
                    Amount_Frame = TbhAmountFrame
                };
                ObservableCollection<Type_of_Beehives> TypeBeehive = new ObservableCollection<Type_of_Beehives>(context.Types_of_Beehives);

                if ((context.Add(newTypeBeehive)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newTypeBeehive}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newTypeBeehive}\" не удалось сохранить в Базу.");

                newTypeBeehive = null;
                TbhName = null;
                TbhSizeBeehive = null;
                TbhSizeFrame = null;
                TbhAmountFrame = 0;
            });

            #region CreateFamily
            BeeGardenName = new ObservableCollection<string>(context.Bee_Gardens.Select(x => x.Name));
            TypeBeeName = new ObservableCollection<string>(context.Types_of_Bees.Select(x => x.Name));
            TypeBeehiveName = new ObservableCollection<string>(context.Types_of_Beehives.Select(x => x.Name));
            CreateFamily = new RelayCommand(obj =>
            {
                Family newFamily = new()
                {
                    Bee_GardenId = context.Bee_Gardens.Where(x => x.Name == FBeeGarden).FirstOrDefault().Id,
                    Type_of_BeesId = context.Types_of_Bees.Where(x => x.Name == FTypeBee).FirstOrDefault().Id,
                    Type_of_BeehivesId = context.Types_of_Beehives.Where(x => x.Name == FTypeBeehive).FirstOrDefault().Id,
                    Reproduction = FReproduction,
                    Productivity = FProductivity
                };
                ObservableCollection<Family> Family = new ObservableCollection<Family>(context.Families);

                if ((context.Add(newFamily)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newFamily}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newFamily}\" не удалось сохранить в Базу.");

                newFamily = null;
                FBeeGarden = null;
                FTypeBee = null;
                FTypeBeehive = null;
                FReproduction = null;
                FProductivity = 0;
            });
            #endregion

            CreateDisease = new RelayCommand(obj =>
            {
                Disease newDisease = new() { Name = DName };
                ObservableCollection<Disease> Disease = new ObservableCollection<Disease>(context.Diseases);

                if ((context.Add(newDisease)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newDisease}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newDisease}\" не удалось сохранить в Базу.");

                newDisease = null;
                DName = null;
            });

            CreateHealing = new RelayCommand(obj =>
            {
                Healing newHealing = new() { Name = HName };
                ObservableCollection<Healing> Healing = new ObservableCollection<Healing>(context.Healings);

                if ((context.Add(newHealing)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newHealing}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newHealing}\" не удалось сохранить в Базу.");

                newHealing = null;
                HName = null;
            });

            CreateSign = new RelayCommand(obj =>
            {
                Sign newSign = new() { Name = SName };
                ObservableCollection<Sign> Sign = new ObservableCollection<Sign>(context.Signs);

                if ((context.Add(newSign)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newSign}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newSign}\" не удалось сохранить в Базу.");

                newSign = null;
                SName = null;
            });

            #region CreateSick
            FamilyId = new ObservableCollection<int>(context.Families.Select(x => x.Id));
            DiseaseName = new ObservableCollection<string>(context.Diseases.Select(x => x.Name));
            SignName = new ObservableCollection<string>(context.Signs.Select(x => x.Name));
            HealingName = new ObservableCollection<string>(context.Healings.Select(x => x.Name));
            CreateSick = new RelayCommand(obj =>
            {
                Sick newSick = new()
                {
                    DiseaseId = context.Diseases.Where(x => x.Name == SiDisease).FirstOrDefault().Id,
                    FamilyId = context.Families.Where(x => x.Id == SiFamily).FirstOrDefault().Id
                };
                ObservableCollection<Sick> Sick = new ObservableCollection<Sick>(context.Sicks);

                if ((context.Add(newSick)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newSick}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newSick}\" не удалось сохранить в Базу.");

                Sign_of_Disease newSignDisease = new()
                {
                    DiseaseId = context.Diseases.Where(x => x.Name == SiDisease).FirstOrDefault().Id,
                    SignId = context.Signs.Where(x => x.Name == SiSign).FirstOrDefault().Id
                };
                ObservableCollection<Sign_of_Disease> SignDisease = new ObservableCollection<Sign_of_Disease>(context.Signs_of_Diseases);

                if ((context.Add(newSignDisease)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newSignDisease}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newSignDisease}\" не удалось сохранить в Базу.");

                Healing_of_Disease newHealingDisease = new()
                {
                    DiseaseId = context.Diseases.Where(x => x.Name == SiDisease).FirstOrDefault().Id,
                    HealingId = context.Healings.Where(x => x.Name == SiHealing).FirstOrDefault().Id
                };

                if ((context.Add(newHealingDisease)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newHealingDisease}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newHealingDisease}\" не удалось сохранить в Базу.");

                newSick = null;
                newSignDisease = null;
                newHealingDisease = null;
                SiFamily = 0;
                SiDisease = null;
                SiSign = null;
                SiHealing = null;
            });
            #endregion

            CreateTypeWork = new RelayCommand(obj =>
            {
                Type_of_Work newTypeWork = new() { Name = TwName };
                ObservableCollection<Type_of_Work> TypeWork = new ObservableCollection<Type_of_Work>(context.Types_of_Work);

                if ((context.Add(newTypeWork)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newTypeWork}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newTypeWork}\" не удалось сохранить в Базу.");

                newTypeWork = null;
                TwName = null;
            });

            #region CreateWork
            TypeWorkName = new ObservableCollection<string>(context.Types_of_Work.Select(x => x.Name));
            CreateWork = new RelayCommand(obj =>
            {
                Work newWork = new()
                {
                    Name = WName,
                    Type_of_WorkId = context.Types_of_Work.Where(x => x.Name == WTypeWork).FirstOrDefault().Id
                };
                ObservableCollection<Work> Work = new ObservableCollection<Work>(context.Works);

                if ((context.Add(newWork)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newWork}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newWork}\" не удалось сохранить в Базу.");

                newWork = null;
                WName = null;
                WTypeWork = null;
            });
            #endregion

            CreateEquipment = new RelayCommand(obj =>
            {
                Equipment newEquipment = new() { Name = EqName };
                ObservableCollection<Equipment> Equipment = new ObservableCollection<Equipment>(context.Equipments);

                if ((context.Add(newEquipment)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newEquipment}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newEquipment}\" не удалось сохранить в Базу.");

                newEquipment = null;
                EqName = null;
            });

            CreateRoom = new RelayCommand(obj =>
            {
                Room newRoom = new() { Name = RName };
                ObservableCollection<Room> Romm = new ObservableCollection<Room>(context.Rooms);

                if ((context.Add(newRoom)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newRoom}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newRoom}\" не удалось сохранить в Базу.");

                newRoom = null;
                RName = null;
            });

            #region CreateTabel
            WorkName = new ObservableCollection<string>(context.Works.Select(x => x.Name));
            TFamilyId = new ObservableCollection<int>(context.Families.Select(x => x.Id));
            EmployeeName = new ObservableCollection<string>(context.Employees.Select(x => x.Second_Name + ' ' + x.First_Name + ' ' + x.Father_Name));
            EquipmentName = new ObservableCollection<string>(context.Equipments.Select(x => x.Name));
            RoomName = new ObservableCollection<string>(context.Rooms.Select(x => x.Name));
            ProductName = new ObservableCollection<string>(context.Products.Select(x => x.Name));
            CreateTabel = new RelayCommand(obj =>
            {
                Tabel newTabel = new()
                {
                    WorkId = context.Works.Where(x => x.Name == TWork).FirstOrDefault().Id,
                    FamilyId = context.Families.Where(x => x.Id == TFamily).FirstOrDefault().Id,
                    EmployeeId = context.Employees.Where(x => x.Second_Name + ' ' + x.First_Name + ' ' + x.Father_Name == TEmployee).FirstOrDefault().Id,
                    EquipmentId = context.Equipments.Where(x => x.Name == TEquipment).FirstOrDefault().Id,
                    RoomId = context.Rooms.Where(x => x.Name == TRoom).FirstOrDefault().Id,
                    ProductId = context.Products.Where(x => x.Name == TProduct).FirstOrDefault().Id,
                    Date_Event = TDateEvent
                };
                ObservableCollection<Tabel> Tabel = new ObservableCollection<Tabel>(context.Tabels);

                if ((context.Add(newTabel)).State != EntityState.Added)
                    throw new DbUpdateException($"\"{newTabel}\" не удалось сохранить.");
                if (context.SaveChanges() < 1)
                    throw new DbUpdateException($"\"{newTabel}\" не удалось сохранить в Базу.");

                newTabel = null;
                TWork = null;
                TFamily = 0;
                TEmployee = null;
                TEquipment = null;
                TRoom = null;
                TProduct = null;
                TDateEvent = default;
            });
            #endregion
        }

        #region RelayCommand
        public RelayCommand CreateProduct { get; }
        public RelayCommand CreateEmployee { get; }
        public RelayCommand CreatePost { get; }
        public RelayCommand CreateBeeGarden { get; }
        public RelayCommand CreateTypeBee { get; }
        public RelayCommand CreateTypeBeehive { get; }
        public RelayCommand CreateFamily { get; }
        public RelayCommand CreateDisease { get; }
        public RelayCommand CreateHealing { get; }
        public RelayCommand CreateSign { get; }
        public RelayCommand CreateSick { get; }
        public RelayCommand CreateTypeWork { get; }
        public RelayCommand CreateWork { get; }
        public RelayCommand CreateRoom { get; }
        public RelayCommand CreateEquipment { get; }
        public RelayCommand CreateTabel { get; }
        #endregion

        #region Product
        public string PName { get; set; }
        #endregion

        #region Employee
        public string ESecondName { get; set; }
        public string EFirstName { get; set; }
        public string EFatherName { get; set; }
        public DateTime EDateBirth { get; set; }
        public string EPhoneNumber { get; set; }
        public string EEmail { get; set; }
        public string ETown { get; set; }
        public string EStreet { get; set; }
        public int EHome { get; set; }
        public string EPost { get; set; }
        public ObservableCollection<string> PostName { get; set; }
        #endregion

        #region Post
        public string PoName { get; set; }
        public int PoSalary { get; set; }
        #endregion

        #region BeeGarden
        public string BName { get; set; }
        public string BTown { get; set; }
        public string BStreet { get; set; }
        public int BHome { get; set; }
        public string BSquare { get; set; }
        #endregion

        #region TypeBee
        public string TbName { get; set; }
        public int TbProductivity { get; set; }
        #endregion

        #region TypeBeehive
        public string TbhName { get; set; }
        public string TbhSizeBeehive { get; set; }
        public string TbhSizeFrame { get; set; }
        public int TbhAmountFrame { get; set; }
        #endregion

        #region Family
        public string FBeeGarden { get; set; }
        public string FTypeBeehive { get; set; }
        public string FTypeBee { get; set; }
        public string FReproduction { get; set; }
        public int FProductivity { get; set; }
        public ObservableCollection<string> BeeGardenName { get; set; }
        public ObservableCollection<string> TypeBeehiveName { get; set; }
        public ObservableCollection<string> TypeBeeName { get; set; }

        #endregion

        #region Disease
        public string DName { get; set; }
        #endregion

        #region Healing
        public string HName { get; set; }
        #endregion

        #region Sign
        public string SName { get; set; }
        #endregion

        #region Sick
        public int SiFamily { get; set; }
        public string SiDisease { get; set; }
        public string SiSign { get; set; }
        public string SiHealing { get; set; }
        public ObservableCollection<int> FamilyId { get; set; }
        public ObservableCollection<string> DiseaseName { get; set; }
        public ObservableCollection<string> SignName { get; set; }
        public ObservableCollection<string> HealingName { get; set; }
        #endregion

        #region TypeWork
        public string TwName { get; set; }
        #endregion

        #region Work
        public string WName { get; set; }
        public string WTypeWork { get; set; }
        public ObservableCollection<string> TypeWorkName { get; set; }
        #endregion

        #region Equipment
        public string EqName { get; set; }
        #endregion

        #region Room
        public string RName { get; set; }
        #endregion

        #region Tabel
        public string TWork { get; set; }
        public int TFamily { get; set; }
        public string TEmployee { get; set; }
        public string TEquipment { get; set; }
        public string TRoom { get; set; }
        public string TProduct { get; set; }
        public DateTime TDateEvent { get; set; }
        public ObservableCollection<string> WorkName { get; set; }
        public ObservableCollection<int> TFamilyId { get; set; }
        public ObservableCollection<string> EmployeeName { get; set; }
        public ObservableCollection<string> EquipmentName { get; set; }
        public ObservableCollection<string> RoomName { get; set; }
        public ObservableCollection<string> ProductName { get; set; }
        #endregion
    }
}
