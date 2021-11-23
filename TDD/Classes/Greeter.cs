namespace TDD.Classes
{
    public class Greeter
    {
        public string GreetPerson(string name)
        {
            return String.Empty;
        }






























        #region Gammalt

        //private string _greetingPhrase;
        //private string _defaultName;

        ///// <summary>Constructor that sets the greeting phrase and the default name</summary>
        //private Greeter(string greetingPhrase, string defaultName)
        //{
        //    _greetingPhrase = greetingPhrase;
        //    _defaultName = defaultName;
        //}

        ///// <summary>A default constructor that sets the greeting phrase to "Hej" and the default name to "Kompis"</summary>
        //public Greeter() : this("Hej", "Kompis") { }

        ///// <summary>
        ///// Greets a person with the name that is provided. If provided name is null or whitespace the Default name will be used.
        ///// </summary>
        ///// <param name="name">The name of the person that we greet</param>
        ///// <returns>The greeting</returns>
        //public string GreetPerson(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        return $"{_greetingPhrase} {_defaultName}";
        //    }

        //    if (name.ToUpper() == name)
        //    {
        //        return $"{_greetingPhrase} {name}!".ToUpper();
        //    }

        //    return $"{_greetingPhrase} {name}";
        //}
        #endregion
    }
}