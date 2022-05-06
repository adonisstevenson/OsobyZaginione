using OsobyZaginione.Models;

namespace OsobyZaginione
{
    public class PersonManager
    {
        public PersonManager AddPerson(Person personModel)
        {
            using (var context = new PersonContext())
            {
                context.Add(personModel);
                // TODO: Wyjasnic dlaczego ID dodawanego filmu to >1000
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    context.Add(personModel);
                    context.SaveChanges();
                }
            }

            return this;
        }

        public PersonManager RemovePerson(int id)
        {
            using (var context = new PersonContext())
            {

                var person = context.People.SingleOrDefault(x => x.ID == id);
                context.Remove(person);
                context.SaveChanges();
            }


            return this;
        }

        public PersonManager UpdatePerson(Person personModel)
        {
            using (var context = new PersonContext())
            {
                context.People.Update(personModel);
                context.SaveChanges();
            }

            return this;
        }


        public Person GetPerson(int id)
        {

            using (var context = new PersonContext())
            {
                Person person = context.People.SingleOrDefault(x => x.ID == id);

                return person;
            }
        }


        public List<Person> GetPeople()
        {
            using (var context = new PersonContext())
            {

                var people = context.People.ToList();
                return people;
            }
        }
    }
}
