
namespace DatsSystem {
    public static class ArrayUtility {
        public static T[] Add<T>(T[] input, T value) {
            T[] result = new T[input.Length + 1];
            for (int i = 0; i < input.Length; i++) {
                result[i] = input[i];
            }
            result[input.Length] = value;
            return result;
        }

        public static T[] Remove<T>(T[] input, T value) {
            T[] result = new T[input.Length - 1];
            int index = 0;
            for (int i = 0; i < input.Length; i++) {
                if (result[index].Equals(value)) {
                    result[index] = result[i];
                    index++;
                }
            }
            return result;
        }
    }
}