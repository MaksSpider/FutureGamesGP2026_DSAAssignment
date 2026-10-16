using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "ResetOutPut", menuName = "Tasks/ResetOutPut")]
    public class ResetOutPut : Task<string, string> {
        public override string Execute(Computer computer, string input) {
            return null;
        }
    }
}
