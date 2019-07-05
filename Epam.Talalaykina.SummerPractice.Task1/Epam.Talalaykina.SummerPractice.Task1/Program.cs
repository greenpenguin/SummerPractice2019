using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.Talalaykina.SummerPractice.Task1
{
    class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());
            //    UserListBL userActions = new UserListBL();
            //    StoreListBL storeActions = new StoreListBL();
            //    UserRatingListBL userRatingActions = new UserRatingListBL();

            //    Console.WriteLine("Select a table: 1 - Users, 2 - Stores, 3 - Rating");
            //    if (int.TryParse(Console.ReadLine(), out int result))
            //    {
            //        switch(result)
            //        {
            //            case 1:
            //                Console.WriteLine("It's Users table: 1 - add, 2 - get by ID, 3 - update by ID, 4 - remove by ID");
            //                if (int.TryParse(Console.ReadLine(), out int result1))
            //                {
            //                    switch (result1)
            //                    {
            //                        case 1:
            //                            Console.WriteLine("Add new user. Input login");
            //                            userActions.Add(new Entities.UserList(Console.ReadLine()));
            //                            break;

            //                        case 2:
            //                            Console.WriteLine("Get user by ID. Input ID");
            //                            if (int.TryParse(Console.ReadLine(), out int userID))
            //                            {
            //                                Console.WriteLine((userActions.GetByID(userID)).ToString());
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            break;

            //                        case 3:
            //                            Console.WriteLine("Update user by ID. Input ID");
            //                            int userIDUpdate;
            //                            if (int.TryParse(Console.ReadLine(), out int userID1))
            //                            {
            //                                userIDUpdate = userID1;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input new login");
            //                            string newLogin = Console.ReadLine();

            //                            userActions.UpdateByID(userIDUpdate, newLogin);
            //                            break;

            //                        case 4:
            //                            Console.WriteLine("Remove user by ID. Input ID");

            //                            if (int.TryParse(Console.ReadLine(), out int userID2))
            //                            {
            //                                userActions.RemoveByID(userID2);
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            break;
            //                        default:
            //                            Console.WriteLine("Wrong input value!");
            //                            break;
            //                    }
            //                }
            //                else
            //                {
            //                    throw new ArgumentException("It's not an integer value!");
            //                }
            //                break;
            //            case 2:
            //                Console.WriteLine("It's Stores table: 1 - add, 2 - get by ID, 3 - update by ID, 4 - remove by ID"); ;

            //                if (int.TryParse(Console.ReadLine(), out int result3))
            //                {
            //                    switch (result3)
            //                    {
            //                        case 1:
            //                            Console.WriteLine("Add new store. Input store's name");
            //                            storeActions.Add(new Entities.StoreList(Console.ReadLine()));
            //                            break;

            //                        case 2:
            //                            Console.WriteLine("Get store by ID. Input ID");
            //                            if (int.TryParse(Console.ReadLine(), out int storeID))
            //                            {
            //                                Console.WriteLine((storeActions.GetByID(storeID)).ToString());
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            break;

            //                        case 3:
            //                            Console.WriteLine("Update store by ID. Input ID");
            //                            int storeIDUpdate;
            //                            if (int.TryParse(Console.ReadLine(), out int storeID1))
            //                            {
            //                                storeIDUpdate = storeID1;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input new name");
            //                            string newName = Console.ReadLine();

            //                            storeActions.UpdateByID(storeIDUpdate, newName);
            //                            break;

            //                        case 4:
            //                            Console.WriteLine("Remove store by ID. Input ID");

            //                            if (int.TryParse(Console.ReadLine(), out int storeID2))
            //                            {
            //                                storeActions.RemoveByID(storeID2);
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            break;
            //                        default:
            //                            Console.WriteLine("Wrong input value!");
            //                            break;
            //                    }
            //                }
            //                else
            //                {
            //                    throw new ArgumentException("It's not an integer value!");
            //                }
            //                break;
            //            case 3:
            //                Console.WriteLine("It's Rating table: 1 - add, 2 - get by ID, 3 - update by ID, 4 - remove by ID"); ;

            //                if (int.TryParse(Console.ReadLine(), out int result4))
            //                {
            //                    switch (result4)
            //                    {
            //                        case 1:
            //                            Console.WriteLine("Add new rating. Input user's ID");
            //                            int userID;
            //                            if (int.TryParse(Console.ReadLine(), out int userIDInput))
            //                            {
            //                                userID = userIDInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input store ID");
            //                            int storeID;
            //                            if (int.TryParse(Console.ReadLine(), out int storeIDInput))
            //                            {
            //                                storeID = storeIDInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input assortment rating (from 1 to 5)");
            //                            int assortmentRating;
            //                            if (int.TryParse(Console.ReadLine(), out int assortmentRatingInput))
            //                            {
            //                                if ((assortmentRatingInput > 5) || (assortmentRatingInput < 1))
            //                                {
            //                                    throw new ArgumentException("This value must be from 1 to 5!");
            //                                }
            //                                else
            //                                {
            //                                    assortmentRating = assortmentRatingInput;
            //                                }
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input price level rating (from 1 to 5)");
            //                            int priceLevelRating;
            //                            if (int.TryParse(Console.ReadLine(), out int priceLevelRatingInput))
            //                            {
            //                                if ((priceLevelRatingInput > 5) || (priceLevelRatingInput < 1))
            //                                {
            //                                    throw new ArgumentException("This value must be from 1 to 5!");
            //                                }
            //                                else
            //                                {
            //                                    priceLevelRating = priceLevelRatingInput;
            //                                }
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input service rating (from 1 to 5)");
            //                            int serviceRating;
            //                            if (int.TryParse(Console.ReadLine(), out int serviceRatingInput))
            //                            {
            //                                if ((serviceRatingInput > 5) || (serviceRatingInput < 1))
            //                                {
            //                                    throw new ArgumentException("This value must be from 1 to 5!");
            //                                }
            //                                else
            //                                {
            //                                    serviceRating = serviceRatingInput;
            //                                }
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            userRatingActions.Add(new Entities.UserRatingList(userID, storeID, assortmentRating, priceLevelRating, serviceRating));
            //                            break;

            //                        case 2:
            //                            Console.WriteLine("Get rating by ID. Input user ID");
            //                            int userIDGet;
            //                            if (int.TryParse(Console.ReadLine(), out int userIDGetInput))
            //                            {
            //                                userIDGet = userIDGetInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            Console.WriteLine("Input store ID");
            //                            int storeIDGet;
            //                            if (int.TryParse(Console.ReadLine(), out int storeIDGetInput))
            //                            {
            //                                storeIDGet = storeIDGetInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            Console.WriteLine((userRatingActions.GetByID(userIDGet, storeIDGet)).ToString());
            //                            break;

            //                        case 3:
            //                            Console.WriteLine("Update rating by ID. Input user ID");
            //                            int userIDUpdate;
            //                            if (int.TryParse(Console.ReadLine(), out int userIDUpdateInput))
            //                            {
            //                                userIDUpdate = userIDUpdateInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input store ID");
            //                            int storeIDUpdate;
            //                            if (int.TryParse(Console.ReadLine(), out int storeIDUpdateInput))
            //                            {
            //                                storeIDUpdate = storeIDUpdateInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input assortment rating (from 1 to 5)");
            //                            int assortmentRatingUpdate;
            //                            if (int.TryParse(Console.ReadLine(), out int assortmentRatingUpdateInput))
            //                            {
            //                                if ((assortmentRatingUpdateInput > 5) || (assortmentRatingUpdateInput < 1))
            //                                {
            //                                    throw new ArgumentException("This value must be from 1 to 5!");
            //                                }
            //                                else
            //                                {
            //                                    assortmentRatingUpdate = assortmentRatingUpdateInput;
            //                                }
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input price level rating (from 1 to 5)");
            //                            int priceLevelRatingUpdate;
            //                            if (int.TryParse(Console.ReadLine(), out int priceLevelRatingUpdateInput))
            //                            {
            //                                if ((priceLevelRatingUpdateInput > 5) || (priceLevelRatingUpdateInput < 1))
            //                                {
            //                                    throw new ArgumentException("This value must be from 1 to 5!");
            //                                }
            //                                else
            //                                {
            //                                    priceLevelRatingUpdate = priceLevelRatingUpdateInput;
            //                                }
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            Console.WriteLine("Input service rating (from 1 to 5)");
            //                            int serviceRatingUpdate;
            //                            if (int.TryParse(Console.ReadLine(), out int serviceRatingUpdateInput))
            //                            {
            //                                if ((serviceRatingUpdateInput > 5) || (serviceRatingUpdateInput < 1))
            //                                {
            //                                    throw new ArgumentException("This value must be from 1 to 5!");
            //                                }
            //                                else
            //                                {
            //                                    serviceRatingUpdate = serviceRatingUpdateInput;
            //                                }
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }

            //                            userRatingActions.UpdateByID(userIDUpdate, storeIDUpdate, assortmentRatingUpdate, priceLevelRatingUpdate, serviceRatingUpdate);
            //                            break;

            //                        case 4:
            //                            Console.WriteLine("Remove store by ID. Input ID");
            //                            int userIDRemove;
            //                            if (int.TryParse(Console.ReadLine(), out int userIDRemoveInput))
            //                            {
            //                                userIDRemove = userIDRemoveInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            Console.WriteLine("Input store ID");
            //                            int storeIDRemove;
            //                            if (int.TryParse(Console.ReadLine(), out int storeIDRemoveInput))
            //                            {
            //                                storeIDRemove = storeIDRemoveInput;
            //                            }
            //                            else
            //                            {
            //                                throw new ArgumentException("It's not an integer value!");
            //                            }
            //                            userRatingActions.RemoveByID(userIDRemove, storeIDRemove);
            //                            break;
            //                        default:
            //                            Console.WriteLine("Wrong input value!");
            //                            break;
            //                    }
            //                }
            //                else
            //                {
            //                    throw new ArgumentException("It's not an integer value!");
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("Wrong input value!");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        throw new ArgumentException("It's not an integer value!");
            //    }

        }
    }
}
