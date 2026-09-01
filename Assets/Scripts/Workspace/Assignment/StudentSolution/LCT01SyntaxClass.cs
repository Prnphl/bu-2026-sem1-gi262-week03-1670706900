using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float Speed;
        public string Color;

        public void Move()
        {
            Debug.Log("Move");
        }
        public void Turn()
        {
            Debug.Log("Turn");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...

            Car car1 = new Car();
            car1.Name = "Ferrari";
            car1.Speed = 100.0f;

            Car car2 = new();
            car2.Name = "Toyota";

            car1.Move();
            car1.Turn();

            // Student code ends HERE 
        }
    }
}
