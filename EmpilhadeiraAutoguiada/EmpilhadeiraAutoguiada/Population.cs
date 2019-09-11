using System;
using System.Collections.Generic;
using System.Text;

namespace EmpilhadeiraAutoguiada
{
    class Population
    {
        public int PopulationSize { get; set; }
        public Forklift[] Forklift { get; set; }

        public Population(int geneNumbers, int populationSize)
        {
            PopulationSize = populationSize;
            Forklift = new Forklift[populationSize];
            for (int i = 0; i < Forklift.Length; i++)
            {
                Forklift[i] = new Forklift(geneNumbers);
            }

        }

        public Population(int populationSize)
        {
            PopulationSize = populationSize;
            Forklift = new Forklift[populationSize];
            for (int i = 0; i < Forklift.Length; i++)
            {
                Forklift[i] = null;
            }
        }
        public void SetForklift(Forklift forklift)
        {
            for (int i = 0; i < Forklift.Length; i++)
            {
                if (Forklift[i] == null)
                {
                    Forklift[i] = forklift;
                    return;
                }
            }
        }

        //número de indivíduos existentes na população
        public int GetNumbersOfForklifts()
        {
            int num = 0;
            for (int i = 0; i < Forklift.Length; i++)
            {
                if (Forklift[i] != null)
                {
                    num++;
                }
            }
            return num;
        }

        //ordena a população pelo valor de aptidão de cada indivíduo, do maior valor para o menor, assim se eu quiser obter o melhor indivíduo desta população, acesso a posição 0 do array de indivíduos
        public void SortPopulation()
        {
            bool change = true;
            while (change)
            {
                change = false;
                for (int i = 0; i < Forklift.Length - 1; i++)
                {
                    if (Forklift[i].Aptitude < Forklift[i + 1].Aptitude)
                    {
                        var temp = Forklift[i];
                        Forklift[i] = Forklift[i + 1];
                        Forklift[i + 1] = temp;
                        change = true;
                    }
                }
            }
        }
    }
        
}
