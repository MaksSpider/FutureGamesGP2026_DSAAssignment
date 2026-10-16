using UnityEngine;

namespace Environment.Tasks {
    public abstract class Task : ScriptableObject {
        public abstract object Execute(Computer computer, object input);
    }

    public abstract class Task<TInput, TOutput> : Task {
        public abstract TOutput Execute(Computer computer, TInput input);

        public override object Execute(Computer computer, object input) {
            if(input != null && input is not TInput) {
                Debug.LogError($"Invalid input type for task: {name}");
                return null;
            }

            TInput typedInput = input == null ? default : (TInput)input;

            return Execute(computer, typedInput);
        }
    }
}
