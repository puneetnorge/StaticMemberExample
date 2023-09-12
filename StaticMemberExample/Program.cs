using System;

/* In this example, we learn about the use of a static member in a class
 */
namespace StaticMemberExample
{

    class Sensor
    {
        private float temperature; // in Celsius
        private double relative_humidity; // 
        private int CO2_conc; // in PPM
        private string model_id; // some string ID defined by any means
        private static int count = 0;// static member of the Sensor class
        
        // This is the default constuctor with modified values
        public Sensor()
        {
            temperature = -999;
            relative_humidity = -999;
            CO2_conc = -999;
        }

        // count is incremented for each method of the Sensor class
        public float read_temperature()
        {
            count = count + 1;
            return temperature;
        }

        // count is incremented for each method of the Sensor class
        public int read_CO2_conc()
        {
            count = count + 1;
            return CO2_conc;
        }

        // count is incremented for each method of the Sensor class
        public void change_temperature(float t1)
        {
            count = count + 1;
            temperature = t1;
        }

        // count is incremented for each method of the Sensor class
        public void change_CO2_conc(int c1)
        {
            count = count + 1;
            CO2_conc = c1;
        }

        // Please note that this is a static method
        public static void Display_Count()
        {
            Console.WriteLine("Current value of count is {0}", count);
        }

        // Please define methods for reading/writing model_id and relative_humidity yourself

    }

    class PLC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sen_obj1 methods");
            Sensor sen_obj1 = new Sensor();
            sen_obj1.change_temperature(25.0F);
            sen_obj1.change_CO2_conc(1055);
            int c1 = sen_obj1.read_CO2_conc();
            float temp = sen_obj1.read_temperature();
            // Display the value of count
            Sensor.Display_Count();

            Console.WriteLine("sen_obj2 methods");
            Sensor sen_obj2 = new Sensor();
            sen_obj2.change_temperature(15.0F);
            temp = sen_obj2.read_temperature();
            sen_obj2.change_CO2_conc(777);
            // Display the value of count
            Sensor.Display_Count();
            Console.ReadKey();

        }
    }


}
