using Cobilas.Collections;

namespace UnityEngine {
    public static class Component_CB_UE_Extensions {

        /// <summary>Buscar um transfome filho.</summary>
        /// <param name="indice">Indice do filho.</param>
        /// <returns>O filho a ser retornado.</returns>
        public static Transform BuscarFilho(this Component V, int indice)
            => V.transform.GetChild(indice);

        /// <summary>Busca parent usando um componente como alvo</summary>
        /// <typeparam name="T">Componente alvo</typeparam>
        /// <returns></returns>
        public static T BuscarParentApartirDe<T>(this Component V) where T : Object {
            Transform Parent = V.transform.parent;
            while (true) {
                if (Parent == null) break;
                if (Parent.GetComponent<T>() != null) break; 
                else if (Parent.GetComponent<T>() == null) { Parent = Parent.parent; }
            }
            if (Parent == null) return (T)null;
            return Parent.GetComponent<T>();
        }

        /// <summary>Busca parents usando um componente como alvo</summary>
        /// <typeparam name="T">Componente alvo</typeparam>
        /// <returns></returns>
        public static T[] BuscarParentsApartirDe<T>(this Component V) where T : Object {
            Transform Parent = V.transform.parent;
            T[] Parents = null;
            while (true) {
                if (Parent == null) break;
                T VLTemp = Parent.GetComponent<T>();
                if (VLTemp != null) { 
                    Parent = Parent.parent; 
                    ArrayManipulation.Add<T>(VLTemp, ref Parents);
                }
                else if (VLTemp == null) { Parent = Parent.parent; }
            }
            return Parents;
        }

        /// <summary>Buscar um transfome filho.</summary>
        /// <param name="NomeFilho">O nome do filho.</param>
        /// <returns>O filho a ser retornado.</returns>
        public static Transform BuscarFilho(this Component V, string NomeFilho) {
            int Indice = V.transform.childCount;
            for (int I = 0; I < Indice; I++) {
                Transform TF = BuscarFilho(V, I);
                if (TF.name == NomeFilho)
                    return TF;
            }
            return null;
        }

        /// <summary>Buscar o primeiro transfome filho que encontrar.</summary>
        /// <typeparam name="T">O tipo do componente do filho.</typeparam>
        /// <returns>O filho a ser retornado.</returns>
        public static T BuscarFilho<T>(this Component V) where T : Object {
            T[] Temp = V.BuscarFilhos<T>();
            return (Temp == null) ? null : Temp[0];
        }

        /// <summary>Buscar um transfome filho usando indice.</summary>
        /// <typeparam name="T">O tipo do componente do filho.</typeparam>
        /// <param name="indice">Indice do filho.</param>
        /// <returns>O filho a ser retornado.</returns>
        public static T BuscarFilho<T>(this Component V, int indice) where T : Object
            => V.BuscarFilho(indice).GetComponent<T>();

        /// <summary>Buscar um transfome filho usando nome.</summary>
        /// <typeparam name="T">O tipo do componente do filho.</typeparam>
        /// <param name="NomeFilho">O nome do filho.</param>
        /// <returns>O filho a ser retornado.</returns>
        public static T BuscarFilho<T>(this Component V, string NomeFilho) where T : Object 
            => V.BuscarFilho(NomeFilho).GetComponent<T>();
        

        /// <summary>Buscar todos os transforms filhos.</summary>
        /// <returns>Os filhos a serem retornados.</returns>
        public static Transform[] BuscarFilhos(this Component V, bool BuscarFilhosDesativados = true) {
            int Indice = V.transform.childCount;
            Transform[] TF = null;
            if (Indice > 0) {
                for (int I = 0; I < Indice; I++) {
                    Transform STF = V.transform.BuscarFilho(I);
                    if (BuscarFilhosDesativados)
                        ArrayManipulation.Add<Transform>(STF, ref TF);
                    else {
                        if(STF.gameObject.activeInHierarchy)
                            ArrayManipulation.Add<Transform>(STF, ref TF);
                    }
                }
            }

            return TF;
        }

        /// <summary>Buscar todos os transforms filhos.</summary>
        /// <typeparam name="T">O tipo do componente do filho.</typeparam>
        /// <returns>Os filhos a serem retornados.</returns>
        public static T[] BuscarFilhos<T>(this Component V, bool BuscarFilhosDesativados = true) where T : Object {
            T[] Res = null;
            Transform[] TFMs = BuscarFilhos(V, BuscarFilhosDesativados);
            for (int I = 0; I < ArrayManipulation.ArrayLength(TFMs); I++)
                if (TFMs[I].GetComponent<T>())
                    ArrayManipulation.Add<T>(TFMs[I].GetComponent<T>(), ref Res);
            return Res;
        }

        /// <summary>Buscar o transform filho ou neto.</summary>
        /// <param name="Nome">O nome do filho ou neto.</param>
        /// <returns>O filho ou neto a ser retornado.</returns>
        public static Transform BuscarFilhoOuNeto(this Component V, string Nome) {
            Transform[] TF = V.BuscarFilhos();
            Transform Res = null;
            for (int I = 0; I < ArrayManipulation.ArrayLength(TF); I++) {
                if (TF[I].name == Nome) { Res = TF[I]; break; }
                else Res = BuscarFilhoOuNeto(TF[I], Nome);
            }
            //Transform[] TF2 = null;
            //if (TF != null)
            //    while (true) {
            //        for (int I = 0; I < TF.Length; I++) {
            //            if (TF[I].name == Nome) return TF[I];
            //            else if (TF[I].childCount > 0) AddMatriz(TF[I].BuscarFilhos(), ref TF2);
            //        }
            //        if (TF2 == null) break;
            //        else {
            //            TF = TF2;
            //            TF2 = null;
            //        }
            //    }

            return Res;
        }

        /// <summary>Buscar o transform filho ou neto.</summary>
        /// <typeparam name="T">O tipo do componente do filho ou neto.</typeparam>
        /// <param name="Nome">O nome do filho ou neto.</param>
        /// <returns>O filho ou neto a ser retornado.</returns>
        public static T BuscarFilhoOuNeto<T>(this Component V, string Nome) where T : Object
            => BuscarFilhoOuNeto(V, Nome).GetComponent<T>();

        public static Transform[] BuscarFilhosENetos(this Component V, bool BuscarFilhosDesativados = true) {
            Transform[] Res = BuscarFilhos(V, BuscarFilhosDesativados);
            for (int I = 0; I < ArrayManipulation.ArrayLength(Res); I++)
                ArrayManipulation.Add<Transform>(BuscarFilhosENetos(Res[I], BuscarFilhosDesativados), ref Res);
            //Transform[] ResTemp = null;
            //AddMatriz(V.transform, ref ResTemp);
            //if (V.transform.childCount > 0) {
            //    while (true) {
            //        Transform[] Temp = null;
            //        for (int I = 0; I < ResTemp.Length; I++) {
            //            if (ResTemp[I].childCount > 0) {
            //                AddMatriz(ResTemp[I].BuscarFilhos(BuscarFilhosDesativados), ref Res);
            //                AddMatriz(ResTemp[I].BuscarFilhos(BuscarFilhosDesativados), ref Temp);
            //            }
            //        }
            //        ResTemp = Temp;
            //        if (ResTemp == null) break;
            //    }
            //}
            return Res;
        }

        public static T[] BuscarFilhosENetos<T>(this Component V, bool BuscarFilhosDesativados = true) where T : Object {
            T[] Res = null;
            Transform[] TF = BuscarFilhosENetos(V, BuscarFilhosDesativados);
            for (int I = 0; I < ArrayManipulation.ArrayLength(TF); I++)
                ArrayManipulation.Add<T>(TF[I].GetComponent<T>(), ref Res);
            return Res;
        }

        public static Transform BuscarNetoApartirDe(this Component V, string ApartirDe, string Nome) 
            => BuscarFilhoOuNeto(V, ApartirDe).BuscarFilhoOuNeto(Nome);

        public static T BuscarNetoApartirDe<T>(this Component V, string ApartirDe, string Nome) where T : Transform
            => BuscarNetoApartirDe(V, ApartirDe, Nome).GetComponent<T>();

        public static bool FilhoExiste(this Component V, string nome)
            => BuscarFilhoOuNeto(V, nome) != null;

        //public static Transform BuscarObjetoRaiz(this Component V, string Nome) 
        //    => CobilasBehaviour.BuscarGameObjectRaiz<Transform>(Nome);

        public static Vector3 AplicaDirecaoDoTransform(this Component V, Vector3 vector)
            => V.transform.right * vector.x + V.transform.up * vector.y + V.transform.forward * vector.z;

        //===========================Metodos de retoação========================================
        //public static Transform R_BuscarPorNome(Component V, string nome) { }
    }
}
