namespace RainingCatsandMutts
{
    interface IProgram
    {
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}