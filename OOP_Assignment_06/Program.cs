namespace OOP_Assignment_06
{
    internal class Program
    {
        static void Main()
        {
            #region Part 01
            #region Q1  Object Copying
            // a) What happens when you assign one object variable to another object variable?
            // Answer => that will create new refrence at stack refer to the same object at the heap .

            // b) Does assigning one object to another create a new object? Explain.
            // Answer => no , because when you assign you make a new refrence and copy what exist at the first refrence at the satck (address of the object) so the two refrences will refer to the same object .

            // c) What is the difference between copying an object and copying its reference?
            // Answer => copying an object creates a separate instance in memory, copying its reference just points another variable to the original instance .
            #endregion
            #region Q2  Shallow Copy vs Deep Copy 
            // a) What is a Shallow Copy? 
            // Answer => create a new object with all members of the original and the Nested objects are shared .

            // b) What is a Deep Copy? 
            // Answer => create a new object with all members of the original and create a new objects of Nested objects  (the original and copy are completely independent) .

            // c) What happens to reference-type members when a Shallow Copy is created? 
            // Answer => the two objects will refere to the same object .

            // d) What happens to reference-type members when a Deep Copy is created? 
            // Answer => the two objects will refer to diffrent objects (independent) .

            // e) Give one situation where Deep Copy would be safer than Shallow Copy. 
            // Answer => When modifying nested data ande this data are refrence type .

            #endregion
            #endregion
        }
    }
}
