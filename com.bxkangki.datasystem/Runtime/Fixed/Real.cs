namespace Fixed {
    [System.Serializable]
    public struct Real {
        public int sign;
        public int i;
        public int d;
        public int accurancy;

        public Real (int acc = Constants.DefaultAccurancy) {
            this.accurancy = acc;
            this.sign = 1;
            this.i = 0;
            this.d = 0;
        }

        public Real (float value = 0f, int acc = Constants.DefaultAccurancy) {
            this.accurancy = acc;
            if (value == 0f) {
                this.sign = 1;
                this.i = 0;
                this.d = 0;
            } else {
                this.sign = (value < 0f) ? -1 : 1;
                float temp = ((value < 0f) ? -value : value);
                this.i = (int)temp;
                this.d = (int)((temp - this.i) * System.Math.Pow(10, acc));
            }
        }

        public float Recover() {
            return (float)(this.sign * (this.i + ((float)this.d / System.Math.Pow(10, this.accurancy))));
        }
    }
}