namespace System.Collections.Generic {
    public static class CBUE_GenericNumericListINTExtension {

        public static void Reorder(this List<int> li) {
            List<int> liTemp = I_Reorder<int>(li, (I, J) => I < J);
            li.Clear();
            li.AddRange(liTemp);
            liTemp.Clear();
            liTemp.Capacity = 0;
            liTemp = null;
        }

        private static List<T> I_Reorder<T>(List<T> list, Func<T, T, bool> _operator) {
            List<T> outList = new List<T>(list.Capacity);
            list.ForEach((I) => {
                bool add = true;
                for (int J = 0; J < outList.Count; J++)
                    if (_operator(I, outList[J])) {
                        outList.Insert(J, I);
                        add = false;
                        break;
                    }
                if (add) outList.Add(I);
            });
            return outList;
        }
    }
}
