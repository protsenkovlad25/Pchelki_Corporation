using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pchelki_Corporation.ViewModels
{
    class ViewController: Base.BaseViewModels
    {
        public ViewController()
        {
            OpenFrame = new RelayCommand(obj =>
            {
                switch (obj as string)
                {
                    case "Product":
                        ViewRight = new View.TProduct();
                        ViewLeft = new View.Add.AProduct();
                        break;
                    case "BeeGarden":
                        ViewRight = new View.Tables.TBeeGarden();
                        ViewLeft = new View.Add.ABeeGarden();
                        break;
                    case "TypeBee":
                        ViewRight = new View.Tables.TType_of_Bees();
                        ViewLeft = new View.Add.AType_of_Bees();
                        break;
                    case "TypeBeehive":
                        ViewRight = new View.Tables.TType_of_Beehives();
                        ViewLeft = new View.Add.AType_of_Beehives();
                        break;
                    case "Family":
                        ViewRight = new View.Tables.TFamily();
                        ViewLeft = new View.Add.AFamily();
                        break;
                    case "Disease":
                        ViewRight = new View.Tables.TDisease();
                        ViewLeft = new View.Add.ADisease();
                        break;
                    case "Healing":
                        ViewRight = new View.Tables.THealing();
                        ViewLeft = new View.Add.AHealing();
                        break;
                    case "Sign":
                        ViewRight = new View.Tables.TSign();
                        ViewLeft = new View.Add.ASign();
                        break;
                    case "Sick":
                        ViewRight = new View.Tables.TSick();
                        ViewLeft = new View.Add.ASick();
                        break;
                    case "HealingDisease":
                        ViewRight = new View.Tables.THealingDisease();
                        break;
                    case "SignDisease":
                        ViewRight = new View.Tables.TSignDisease();
                        break;
                    case "TypeWork":
                        ViewRight = new View.Tables.TType_of_Work();
                        ViewLeft = new View.Add.AType_of_Work();
                        break;
                    case "Work":
                        ViewRight = new View.Tables.TWork();
                        ViewLeft = new View.Add.AWork();
                        break;
                    case "Post":
                        ViewRight = new View.Tables.TPost();
                        ViewLeft = new View.Add.APost();
                        break;
                    case "EmployeePost":
                        ViewRight = new View.Tables.TEmployeePost();
                        break;
                    case "Employee":
                        ViewRight = new View.Tables.TEmployee();
                        ViewLeft = new View.Add.AEmployee();
                        break;
                    case "Equipment":
                        ViewRight = new View.Tables.TEquipment();
                        ViewLeft = new View.Add.AEquipment();
                        break;
                    case "Room":
                        ViewRight = new View.Tables.TRoom();
                        ViewLeft = new View.Add.ARoom();
                        break;
                    case "Tabel":
                        ViewRight = new View.Tables.TTabel();
                        ViewLeft = new View.Add.ATabel();
                        break;
                    case "Sale":
                        ViewRight = new View.Tables.TSale();
                        ViewLeft = new View.Add.ASale();
                        break;
                    case "ProductSold":
                        break;
                    case "Client":
                        ViewRight = new View.Tables.TClient();
                        break;
                }
            });
        }

        public UserControl ViewLeft { get; set; }
        public UserControl ViewRight { get; set; }

        public RelayCommand OpenFrame { get; }
    }
}
