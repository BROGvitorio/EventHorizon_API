namespace EventHorizon_API.Models.Owners
{
    public class Person: Owner
    {
        public string Cpf { get; private set; }
        public string FullName { get; private set; }
        public DateOnly BirthDate { get; private set; }
        public decimal Salary { get; private set; }

        public Person ()
        {
            Type = OwnerType.person;
        }
    }
}
