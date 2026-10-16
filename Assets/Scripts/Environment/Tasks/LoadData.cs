using System.IO;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "LoadData", menuName = "Tasks/LoadData")]
    public class LoadData : Task<string, string> {
        [SerializeField] private string path = "testEmployees.json";

        public override string Execute(Computer computer, string input) {
            string filePath = string.IsNullOrWhiteSpace(input) ? path : input;

            string fullPath = Path.Combine(
                Application.streamingAssetsPath,
                filePath
            );

            if(!File.Exists(fullPath)) {
                Debug.LogWarning($"File doesn't exist: {fullPath}");
                return null;
            }

            return File.ReadAllText(fullPath);
        }
    }
}
