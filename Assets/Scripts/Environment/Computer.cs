using Environment.Tasks;
using UnityEngine;
using Framework;
using System;

namespace Environment {
    public class EmployeeData {
        public Employee[] employees;
    }

    public class Employee {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom;
        public string lastExitFromEngineRoom;
    }

    public class Computer : MonoBehaviour, IInteractable {
        [SerializeField] private Queue<Task> tasks = new();

        [NonSerialized] public EmployeeData Employees;

        public void OnInteract()
        {
            object result = null;

            while(!tasks.IsEmpty()) {
                Task task = tasks.Pop();
                result = task.Execute(this, result);
            }

            for(int i = 0; i < Employees.employees.Length; i++)
            {
                print(i);
                print(Employees.employees[i].name);
            }
        }
    }
}
