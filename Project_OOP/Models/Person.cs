namespace Project_OOP.Moldels
{
    // Базовий клас для всіх персон (Наприклад: пасажир, пілот, стюардеса і тд. )
    public abstract class Person
    {
        public virtual string Name { get; protected set; }     // Ім'я
        public virtual int Age { get; protected set; }         // Вік


        protected Person (string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
