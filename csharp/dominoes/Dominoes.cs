public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (!dominoes.Any()) return true;
        return Search(new List<(int, int)>(), dominoes.ToList());
    }

    private static bool Search(
        List<(int, int)> chain, List<(int, int)> remaining)
    {
        if (remaining.Count == 0)
            return chain[0].Item1 == chain[^1].Item2;
        
        for (int i = 0; i < remaining.Count; i++)
        {
            var currDomino = remaining[i];

            if (chain.Count == 0)
            {
                chain.Add(currDomino);
                remaining.RemoveAt(i);
                
                if (Search(chain, remaining))
                    return true;

                chain.RemoveAt(chain.Count - 1);
                remaining.Insert(i, currDomino);

                // try flipped domino
                chain.Add((currDomino.Item2, currDomino.Item1));
                remaining.RemoveAt(i);

                if (Search(chain, remaining))
                    return true;

                chain.RemoveAt(chain.Count - 1);
                remaining.Insert(i, currDomino);

                continue;
            }

            var prevDomino = chain[chain.Count - 1];

            if (prevDomino.Item2 == currDomino.Item1)
            {
                chain.Add(currDomino);
                remaining.RemoveAt(i);

                if (Search(chain, remaining)) return true;

                chain.RemoveAt(chain.Count - 1);
                remaining.Insert(i, currDomino);
            }

            // check if flipped currDomino works
            if (prevDomino.Item2 == currDomino.Item2)
            {
                var flippedCurrDominoe = (currDomino.Item2, currDomino.Item1);
                chain.Add(flippedCurrDominoe);
                remaining.RemoveAt(i);

                if (Search(chain, remaining)) return true;

                chain.RemoveAt(chain.Count - 1);
                remaining.Insert(i, currDomino);
            }
        }

        return false;
    }
}