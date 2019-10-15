using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt4
{
    class Matriz
    {
        int[,] matriz = new int[6, 7] { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
        int turno;
        int insx;
        int insy;

        public void imprimir()

        {

            for (int i = 1; i <= 6; i++)

            {

                Console.Write("\n");

                for (int j = 1; j <= 6; j++)

                {

                    Console.Write(matriz[i, j] + " ");

                }

            }

        }

        public void insertar(int x)
        {
            int y = 0; /// posicion en y de la matriz
            while (matriz[y, x] != 0)
            {
                y++;
            }
            y--;
            matriz[y - 1, x] = turno;
            insx = x;
            insy = y;
            turno = (turno % 2) + 1;
        }

        public void Finalizar(int fila, int columna)

        {

            int contador = 0;

            int fila_temporal = fila;

            while (fila_temporal < 6)

            {

                if (matriz[fila_temporal, columna] == turno)

                {

                    contador++;

                }
                else

                {

                    contador = 0;

                }

                if (contador == 4)

                {

                    fila_temporal = 7;

                    ////////////////////////////////ganar();

                }

                fila_temporal++;

            }

            int columna_temporal = columna;

            contador = 0;

            while (columna_temporal < 7)

            {

                if (matriz[fila, columna_temporal] == turno)

                {

                    contador++;

                }

                else

                {

                    contador = 0;

                }

                if (contador == 4)

                {

                    columna_temporal = 7;

                   //////////////////////////// ganar();

                }

                columna_temporal++;

            }

            fila_temporal = fila;

            columna_temporal = columna;

            contador = 0;

            while (fila_temporal == 0 || columna_temporal == 0)

            {

                fila_temporal--;

                columna_temporal--;

            }

            while (fila_temporal < 6 || columna_temporal < 7)

            {

                if (matriz[fila_temporal, columna_temporal] == turno)

                {

                    contador++;

                }
                else

                {

                    contador = 0;

                }

                if (contador == 4)

                {

                   //////////////////////////// ganar();

                }

                fila_temporal++;

                columna_temporal++;

            }

            fila_temporal = fila;

            columna_temporal = columna;

            contador = 0;

            while (fila_temporal == 0 || columna_temporal == 6)

            {

                fila_temporal--;

                columna_temporal++;

            }

            while (fila_temporal < 6 || columna_temporal > -1)

            {

                if (matriz[fila_temporal, columna_temporal] == turno)

                {

                    contador++;

                }

                else

                {

                    contador = 0;

                }

                if (contador == 4)

                {

                    //////////////////////////////ganar();

                }

                fila_temporal++;

                columna_temporal--;

            }

        }
    }
}
