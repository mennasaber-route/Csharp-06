using System.Drawing;
using System.Runtime.InteropServices;

namespace Assignment_5
{
    internal class Program
    {

        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }


        class Book
        {
            public Genre Genre { get; set; }
        }

        static void Main(string[] args)
        {

            // **********     Part 2 from assignment 5     **********

            #region Question4
            ////4-Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre
            ////property to Book, assign it Genre.Science, and print it.

            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);

            #endregion


            #region Question5
            ////5-Using the Genre enum above, print the underlying int value of
            ////Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.


            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            #endregion


            #region Question6
            ////6-Given int genreNumber = 1;, cast it into a Genre value and print the result

            //int genreNumber = 1;
            //Genre genreValue = (Genre)genreNumber;
            //Console.WriteLine(genreValue);

            #endregion


            #region Question7
            ////7-Given string genreText = "Science";, convert it into a Genre value using
            ////Enum.Parse() and print the result


            //string genreText = "Science";
            //Genre genreValueFromString = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genreValueFromString);

            #endregion


            #region Question8
            ////8-Given string genreText = "Mystery"; (not a valid Genre value), use
            ////Enum.TryParse() to attempt the conversion. Print "Unknown genre" if it  fails.


            //string genreText = "Mystery";
            //Genre genreValue;
            //if (Enum.TryParse(genreText, out genreValue))
            //{
            //    Console.WriteLine(genreValue);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}

            #endregion



            //           Part 02 — Practical Questions        //

            #region Part 02 — Practical Questions


            //Console.WriteLine("===== Smart Delivery Management System =====");
            //Console.WriteLine();

            Console.WriteLine("Enter Shipment 1");
            //string Shipment1 = Console.ReadLine();

            Console.Write(" Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write(" Description: ");
            string description1 = Console.ReadLine();

            Console.Write(" Weight: ");
            double weight1 = double.Parse(Console.ReadLine());

            Console.Write(" Delivery Fee: ");
            decimal deliveryFee1 = decimal.Parse(Console.ReadLine());

            //Console.WriteLine(" Destination:");

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber1 = int.Parse(Console.ReadLine());


            DeliveryAddress address1 =
                new DeliveryAddress(city1, street1, buildingNumber1);


            Shipment shipment1 =
                new Shipment(
                    trackingCode1,
                    description1,
                    weight1,
                    deliveryFee1,
                    address1);

            Console.WriteLine();
            Console.WriteLine("Enter Shipment 2");

            Console.Write(" Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write(" Description: ");
            string description2 = Console.ReadLine();

            Console.Write(" Weight: ");
            double weight2 = double.Parse(Console.ReadLine());

            Console.Write(" Delivery Fee: ");
            decimal deliveryFee2 = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Destination:");

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber2 = int.Parse(Console.ReadLine());


            DeliveryAddress address2 =
                new DeliveryAddress(city2, street2, buildingNumber2);


            Shipment shipment2 =
                new Shipment(
                    trackingCode2,
                    description2,
                    weight2,
                    deliveryFee2,
                    address2);

            Console.WriteLine();
            Console.WriteLine("Enter Shipment 3");

            Console.Write(" Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write(" Description: ");
            string description3 = Console.ReadLine();

            Console.Write(" Weight: ");
            double weight3 = double.Parse(Console.ReadLine());

            Console.Write(" Delivery Fee: ");
            decimal deliveryFee3 = decimal.Parse(Console.ReadLine());

            //Console.WriteLine(" Destination:");

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber3 = int.Parse(Console.ReadLine());


            DeliveryAddress address3 =
                new DeliveryAddress(city3, street3, buildingNumber3);


            Shipment shipment3 =
                new Shipment(
                    trackingCode3,
                    description3,
                    weight3,
                    deliveryFee3,
                    address3);

            Console.WriteLine();
            Console.WriteLine("Shipment 1");

            shipment1.PrintShipment();


            Console.WriteLine();
            Console.WriteLine("Shipment 2");

            shipment2.PrintShipment();


            Console.WriteLine();
            Console.WriteLine("Shipment 3");

            shipment3.PrintShipment();

            Console.WriteLine();
            Console.WriteLine(" DeliveryAddress Copy Test");

            DeliveryAddress originalAddress =
                new DeliveryAddress("Cairo", "Nasr Street", 10);

            DeliveryAddress copiedAddress =
                originalAddress;


            copiedAddress.SetCity("Giza");
            copiedAddress.SetStreet("Haram Street");
            copiedAddress.SetBuildingNumber(20);

            Console.WriteLine(
                $"Original Address: {originalAddress.GetFullAddress()}");

            Console.WriteLine(
                $"Copied Address: {copiedAddress.GetFullAddress()}");

            #endregion

        }
        // ***********   Part 1 from assignment 6  OOP 01    **********
        //                 Part 01 : Theoretical Questions


        #region Question1
        //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified ?

        //DeliveryAddress is a struct, so it is a value type.When it is copied, 
        // a copy of its data is created and Modifying the copied variable does not affect
        //the original variable.

        //                         -----------------//
        //b) What happens when a Customer variable is copied into another variable and one variable modifies the object

        //     Customer is a class, so it is a reference type.Copying the variable copies the reference to the same object.Therefore,
        //     modifying the object through one variable affects the other variable


        #endregion


        #region Question2
        //a) a) Identify at least three problems with this design from an encapsulation perspective.

        //1 — الـfields public  ex  shipment.Weight = -100;
        //2 - مفيش Validation      ex   shipment.DeliveryFee = -500;
        //3 -  فأي كود يقدر يقرأ ويعدل كل حاجة بحرية مفيش تحكم في القراءة والكتابة


        //b) b) How can private fields and public properties improve this design?

        //private double _weight;
        //public double Weight
        //{
        //    get
        //    {
        //        return _weight;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            _weight = value;
        //        }
        //    }
        //}


        // or 
        //public struct Shipment
        //{
        //    private double _weight;
        //    public double GetWeight()
        //    {
        //        return _weight;
        //    }
        //    public void SetWeight(double weight)
        //    {
        //        if (weight > 0)
        //        {
        //            _weight = weight;
        //        }
        //    }
        //}

        #endregion

    }
}

