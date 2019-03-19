using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpExercises
{
    class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Aluno()
        {

        }

        public override string ToString()
        {
            return Id + "Name: " + Name + "age of " + Age + "Email: " + Email;
        }
    }
}
