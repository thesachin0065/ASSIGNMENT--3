﻿using As3;
using Assignment3;
using System;

Program 1 -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.setName("Sachin Yadav");
            Console.WriteLine(u1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        private String name;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }
}

Program2 -
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login l1 = new Login();
            l1.setNameLogin("Sachin Yadav");
            Console.WriteLine(l1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        private String name;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }
    class Login : User
    {
        public void setNameLogin(String name)
        {
            this.setName(name);
        }
    }
}

Program3 -

using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace As3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Assignment3.Program program = new Assignment3.Program();
            Console.WriteLine(program.name);
        }
    }
}


Program 4 -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login l1 = new Login();
            l1.setNameLogin("Sachin Yadav");
            Console.WriteLine(l1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        protected String name;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }
    class Login : User
    {
        public void setNameLogin(String name)
        {
            this.name = name;
        }
    }
}

Program5 -

Assembly1 -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("As3")]

namespace Assignment3
{
    internal class Program
    {
        internal String name = "SRK";
        protected internal void getName()
        {
            Console.WriteLine(name);
        }

    }

}

Assembly2 -

using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace As3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Assignment3.Program program = new Assignment3.Program();
            program.getName();
            Console.ReadLine();
        }
    }
}


Program6 -
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login l1 = new Login();
            l1.setNameLogin("Sachin Yadav");
            Console.WriteLine(l1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        public String name;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }
    class Login : User
    {
        public void setNameLogin(String name)
        {
            this.name = name;
        }
    }
}

Program7 -
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User l1 = new User();
            l1.setName("Sachin Yadav");
            Console.WriteLine(l1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        public String name = "SRK";
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }

}

Program8 -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User l1 = new User();
            l1.setProfile("Sachin Yadav", 23);
            l1.getProfile();
            Console.ReadLine();
        }
    }
    class User
    {
        public String name = "SRK";
        private int age;
        public void setProfile(String name, int age)
        {
            this.name = name;
            this.setAge(age);
        }
        private void setAge(int age)
        {
            this.age = age;
        }
        public void getProfile()
        {
            Console.WriteLine("NAME :" + name + " " + "Age :" + age);
        }
    }

}

Program9 -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login l1 = new Login();
            l1.setNameLoginDetails("Sachin Yadav", 21);
            l1.getProfile();
            Console.ReadLine();
        }
    }
    class User
    {
        public String name = "SRK";
        private int age;
        protected void setProfile(String name, int age)
        {
            this.name = name;
            this.setAge(age);
        }
        private void setAge(int age)
        {
            this.age = age;
        }
        public void getProfile()
        {
            Console.WriteLine("NAME :" + name + " " + "Age :" + age);
        }
    }
    class Login : User
    {
        public void setNameLoginDetails(String name, int age)
        {
            this.setProfile(name, age);
        }
    }
}

Program10 -

Assembly1 -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("As3")]

namespace Assignment3
{
    internal class Program
    {
        internal String name;
        internal Program(String name)
        {
            this.name = name;
        }
        protected internal void getName()
        {
            Console.WriteLine(name);
        }

    }

}

Assembly2 -

using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace As3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Assignment3.Program program = new Assignment3.Program("Sachin Yadav");
            program.getName();
            Console.ReadLine();
        }
    }
}