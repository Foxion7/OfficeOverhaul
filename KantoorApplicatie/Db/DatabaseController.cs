﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KantoorApplicatie.Models;
using KantoorApplicatie.Models.Invoice;
using KantoorApplicatie.Models.Theme;
using KantoorApplicatie.Properties;
using KantoorApplicatie.Models.Floor;
using System.Windows.Forms;
using System.Drawing;

namespace KantoorApplicatie.Db
{
    public static class DatabaseController
    {

        public static List<Product> productList = GetProducts();
        public static List<Theme> themeList = GetThemes();
        public static List<SubTheme> subThemeList = GetSubThemes();
        public static List<FloorMaterial> floorMaterialList = GetFloorMaterial();
        public static List<FloorType> floorTypeList = GetFloorType();
        public static List<Representative> representativeList = GetRepresentatives();
        public static List<Customer> customerList = GetCustomers();
        public static List<InvoiceData> invoiceList = GetInvoiceData();
        public static List<Room> roomList = GetRooms();

        ///  Everything with products.
        // Adds products into the product table inside the database.
        public static void AddProducts(Product p)
        {
            using (var mc = new MyContext())
            {
                mc.products.Add(p);
                mc.SaveChanges();
            }
            productList = GetProducts();
        }

        // Adds customer to database.
        public static void AddCustomer(Customer customer)
        {

            using (var mc = new MyContext())
            {
                mc.customers.Add(customer);
                mc.SaveChanges();
            }
            customerList = GetCustomers();
        }

        // Adds room to database.
        public static void AddRoom(Room room)
        {
            using (var mc = new MyContext())
            {
                FloorType floorType = (from r in mc.floorType
                                       where r.floorTypeId == room.floorType.floorTypeId
                                       select r).Single();
                //Room newRoom = new Room(room.width, room.height, room.shape, floorType);

                var newRoom = new Room {
                    width = room.width,
                    height = room.height,
                    floorType = (from s in mc.floorType
                               where s.name == floorType.name
                               select s).Single(),
                };

                mc.rooms.Add(newRoom);
                mc.SaveChanges();
            }
            roomList = GetRooms();
        }

        // Adds invoice data to database.
        public static void AddInvoice(InvoiceData invoiceData)
        {
            using (var mc = new MyContext())
            {
                var invoice = new InvoiceData
                {
                    customer = (from c in mc.customers
                                where c.companyName.Equals(invoiceData.customer.companyName)
                                && c.department.Equals(invoiceData.customer.department)
                                && c.name.Equals(invoiceData.customer.name)
                                select c).Distinct().First(),
                    representative = (from r in mc.representatives
                                      where r.RepresentativeId == invoiceData.representative.RepresentativeId
                                      select r).Distinct().First(),
                    room = mc.rooms.OrderByDescending(r => r.roomId).Distinct().First(),
                    invoiceDate = invoiceData.invoiceDate
                };
                mc.invoices.Add(invoice);
                mc.SaveChanges();
            }
            invoiceList = GetInvoiceData();
        }

        // Adds OrderedProduct to database.
        public static void AddOrderedProduct(int invId, Product p, int amt)
        {
            using (var mc = new MyContext())
            {
                var orderedProduct = new OrderedProduct
                {
                    //invoiceData = DatabaseController.invoiceList.Find(i => i.InvoiceDataId == invoice.InvoiceDataId),
                    invoiceData = (from s in mc.invoices
                                   where s.InvoiceDataId == invId
                                   select s).Single(),
                    //product = DatabaseController.productList.Find(p => p.name == ipp.product.name),
                    product = (from s in mc.products
                               where s.productId == p.productId
                               select s).Single(),
                    amount = amt
                };
                mc.orderedProducts.Add(orderedProduct);
                mc.SaveChanges();
            }            
        }

        // Returns all products inside the database.
        public static List<Product> GetProducts()
        {
            List<Product> pc;
            using (var mc = new MyContext())
            {
                pc = (from s in mc.products
                      select s).ToList<Product>();
            }
            return pc;
        }

        public static List<Room> GetRooms()
        {
            List<Room> r;
            using (var mc = new MyContext())
            {
                r = (from s in mc.rooms
                      select s).ToList<Room>();
            }
            return r;
        }

        // Returns a single product with a certain id.
        public static Product GetProductById(int id)
        {
            Product temp;
            using (var mc = new MyContext())
            {
                temp = mc.products.Where(v => v.productId == id).Single();
            }
            return temp;
        }

        /// Everything with theme's.
        // Add theme's.
        public static void AddTheme(Theme t)
        {
            using (var mc = new MyContext())
            {
                mc.themes.Add(t);
                mc.SaveChanges();
            }
            //themeList = GetThemes();
        }
        // Add subTheme's
        public static void AddSubTheme(string nm, Bitmap img, int themeId)
        {
            using (var mc = new MyContext())
            {
                var subTheme = new SubTheme
                {
                    name = nm,
                    image = Controllers.Converter.ImageToByteArray(img),
                    lastUsed = 0,
                    theme = (from t in mc.themes
                             where t.themeId == themeId
                             select t).Single()
                };
                mc.subThemes.Add(subTheme);
                mc.SaveChanges();
            }
            subThemeList = GetSubThemes();
            themeList = GetThemes();
        }

        // Deletes subTheme
        public static void DeleteSubTheme(SubTheme st)
        {
            using (var mc = new MyContext())
            {
                // Finds selected subtheme
                var subtheme = from sT in mc.subThemes
                               where sT.subThemeId == st.subThemeId
                               select sT;
                // Removes selected subtheme
                mc.subThemes.Remove(subtheme.First());
                // Check
                mc.SaveChanges();
            }
            subThemeList = GetSubThemes();
        }

        // Get themes
        public static List<Theme> GetThemes()
        {
            List<Theme> pc;
            using (var mc = new MyContext())
            {
                pc = mc.themes.ToList();
            }
            return pc;
        }
        // Get all subthemes
        public static List<SubTheme> GetSubThemes()
        {
            List<SubTheme> pc;
            using (var mc = new MyContext())
            {
                pc = mc.subThemes.Include("Theme").ToList();
            }
            return pc;
        }
        // If there are no theme's add them.
        public static void AddThemesForTheFirstRun()
        {
            using (var mc = new MyContext())
            {
                List<Theme> pc = (from s in mc.themes
                                  select s).ToList<Theme>();
                if (pc.Count == 0)
                {
                    List<Theme> Themes = new List<Theme>
                    {
                        new Theme("School"),
                        new Theme("Medisch"),
                        new Theme("Factory"),
                        new Theme("ICT"),
                        new Theme("Afbeeldingen")
                    };
                    List<SubTheme> subThemes = new List<SubTheme>
                    {
                        new SubTheme("School1", Resources.Background_School1, Themes[0]),
                        new SubTheme("School2", Resources.Background_School2, Themes[0]),
                        new SubTheme("Medical1", Resources.Background_Medical1, Themes[1]),
                        new SubTheme("Medical2", Resources.Background_Office, Themes[1]),
                        new SubTheme("Factory1", Resources.Background_Metal1, Themes[2]),
                        new SubTheme("Factory2", Resources.Background_Metal2, Themes[2]),
                        new SubTheme("ICT1", Resources.Background_ICT, Themes[3])
                    };

                    foreach (Theme t in Themes)
                    {
                        mc.themes.Add(t);
                    }
                    foreach (SubTheme t in subThemes)
                    {
                        mc.subThemes.Add(t);
                    }
                    mc.SaveChanges();
                }
            }
            themeList = GetThemes();
            subThemeList = GetSubThemes();
        }
        // Everything with floors
        // Add Floors if there are no floors in the database
        public static void AddFloorsForFirstRun()
        {
            int count = DatabaseController.GetFloorMaterial().Count;
            Console.WriteLine(count);
            if (count == 0) {
                FloorMaterial wood = new FloorMaterial("Hout");
                FloorType woodType = new FloorType("Regulier", (float)19.95, Resources.WoodFloor);
                FloorType woodType2 = new FloorType("Parket", (float)19.95, Resources.parket);
                FloorType woodType3 = new FloorType("Klein", (float)19.95, Resources.SmallerPlank);
                FloorType woodType4 = new FloorType("Donker", (float)19.95, Resources.DarkerPlank);

                woodType.floorMaterial = wood;
                woodType2.floorMaterial = wood;
                woodType3.floorMaterial = wood;
                woodType4.floorMaterial = wood;
                FloorMaterial steen = new FloorMaterial("Steen");
                
                using (var mc = new MyContext()) 
                {
                    mc.floorMaterial.Add(wood);
                    mc.floorMaterial.Add(steen);

                    mc.floorType.Add(woodType);
                    mc.floorType.Add(woodType2);
                    mc.floorType.Add(woodType3);
                    mc.floorType.Add(woodType4);
                    mc.SaveChanges();
                }
                floorMaterialList = GetFloorMaterial();
                floorTypeList = GetFloorType();
            }
        }

        // Clears the last used subtheme
        public static void ClearLastUsed()
        {
            using (var mc = new MyContext())
            {
                var subTheme = (from s in mc.subThemes
                                where s.lastUsed != 0
                                select s).ToArray();
                foreach (var st in subTheme)
                {
                    st.lastUsed = 0;
                    mc.SaveChanges();
                }
            }
        }

        // Sets the last used subtheme
        public static void setLastUsed(SubTheme st)
        {
            using (var mc = new MyContext())
            {
                ClearLastUsed();
                var subTheme = (from s in mc.subThemes
                                where s.subThemeId == st.subThemeId
                                select s).Single();
                subTheme.lastUsed = 1;
                mc.SaveChanges();
            }
        }

        // Get last theme
        public static SubTheme getLastSubTheme()
        {
            List<SubTheme> st;
            using (var mc = new MyContext())
            {
                st = mc.subThemes.Include("Theme").Where(v => v.lastUsed == 1).ToList();
            }

            if (st.Count > 0)
            {
                SubTheme Subtheme = st.First();
                return Subtheme;
            }
            return null;
        }

        // Get floor material
        public static List<FloorMaterial> GetFloorMaterial()
        {
            List<FloorMaterial> pc;
            using (var mc = new MyContext())
            {
                pc = mc.floorMaterial.ToList<FloorMaterial>();
            }
            return pc;
        }
        // Get floor type
        public static List<FloorType> GetFloorType()
        {
            List<FloorType> pc;
            using (var mc = new MyContext())
            {
                pc = mc.floorType.Include("FloorMaterial").ToList(); 
            }
            return pc;
        }

        // Get customers
        public static List<Customer> GetCustomers()
        {
            List<Customer> c;
            using (var mc = new MyContext())
            {
                c = mc.customers.ToList();
            }
            return c;
        }

        // Get representatives
        public static List<Representative> GetRepresentatives()
        {
            List<Representative> r;
            using (var mc = new MyContext())
            {
                r = mc.representatives.ToList();
            }
            return r;
        }

        // Get invoicedata
        public static List<InvoiceData> GetInvoiceData()
        {
            List<InvoiceData> id;
            using (var mc = new MyContext())
            {
                id = mc.invoices.Include("Room")
                    .Include("Room.floortype")
                    .Include("Representative")
                    .Include("Customer")
                    .Include("orderedProducts")
                    .Include("orderedProducts.product")
                    .ToList();
            }
            return id;
        }

        // Changes a product's active property.        
        public static void SetProductActiveProperty(Product productToChange, bool b)
        {
            using (var mc = new MyContext())
            {
                var product = mc.products.SingleOrDefault(p => p.productId == productToChange.productId);
                if (product != null)
                {

                    product.active = b;
                    mc.SaveChanges();
                }
            }
            productList = GetProducts();
        }
        // Save lines to database when you drew your own room.
        public static void AddLinesToDatabase(Room r, List<Line> lines)
        {
            using (var mc = new MyContext())
            {
                AddRoom(r);
                r.roomId = roomList.Last().roomId;
                foreach (Line l in lines)
                {
                    var myLine = new Line {
                        x1 = l.x1,
                        y1 = l.y1,
                        x2 = l.x2,
                        y2 = l.y2
                    };

                    myLine.room = (from t in mc.rooms
                                   where t.roomId == r.roomId
                                   select t).Single();
                    mc.lines.Add(myLine);
                }
                mc.SaveChanges();
            }
        }
        // Get room by id.
        public static Room GetRoomById(int id)
        {
            Room room;
            using(var mc = new MyContext())
            {
                mc.subThemes.Include("Theme").Where(v => v.lastUsed == 1).ToList();
                room = mc.rooms.Include("floorType").Include("lines").Where(v => v.roomId == id).Single();
            }
            return room;
        }
    }
}

