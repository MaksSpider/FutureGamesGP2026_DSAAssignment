using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Environment.Tasks {

    [CreateAssetMenu(fileName = "InsertData", menuName = "Tasks/InsertData")]
    public class InsertData : Task<string, string> {

        public override string Execute(Computer computer, string input) {
            if(string.IsNullOrWhiteSpace(input)) {
                Debug.LogWarning($"[Insert Data Task] require input to work!");
                return null;
            }

            computer.Employees = JsonConvert.DeserializeObject<EmployeeData>(input);

            return null;
        }
    }
}
