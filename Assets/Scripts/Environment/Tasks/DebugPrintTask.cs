using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "DebugPrint Task", menuName = "Tasks/DebugPrint Task")]
    public class DebugPrintTask : Task<string, string> {
        public override string Execute(Computer computer, string input) {
            if(string.IsNullOrWhiteSpace(input)) {
                Debug.LogWarning($"[Debug Print Task] require input to work!");
                return null;
            }

            Debug.Log(input);

            return input;
        }
    }
}
