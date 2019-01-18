namespace BlazorMessenger.Components
{
    /// <summary>
    /// Represents an navbar color modifier
    /// </summary>
    public struct NavbarColor
    {
        private readonly string _cssClass;

        /// <summary>
        /// Gets the primary navbar color modifier
        /// </summary>
        public static NavbarColor Primary
        {
            get { return new NavbarColor("is-primary"); }
        }

        /// <summary>
        /// Gets the link navbar color modifier
        /// </summary>
        public static NavbarColor Link
        {
            get { return new NavbarColor("is-link"); }
        }

        /// <summary>
        /// Gets the info navbar color modifier
        /// </summary>
        public static NavbarColor Info
        {
            get { return new NavbarColor("is-info"); }
        }

        /// <summary>
        /// Gets the success navbar color modifier
        /// </summary>
        public static NavbarColor Success
        {
            get { return new NavbarColor("is-success"); }
        }

        /// <summary>
        /// Gets the warning navbar color modifier
        /// </summary>
        public static NavbarColor Warning
        {
            get { return new NavbarColor("is-warning"); }
        }

        /// <summary>
        /// Gets the danger navbar color modifier
        /// </summary>
        public static NavbarColor Danger
        {
            get { return new NavbarColor("is-danger"); }
        }

        /// <summary>
        /// Gets the black navbar color modifier
        /// </summary>
        public static NavbarColor Black
        {
            get { return new NavbarColor("is-black"); }
        }

        /// <summary>
        /// Gets the dark navbar color modifier
        /// </summary>
        public static NavbarColor Dark
        {
            get { return new NavbarColor("is-dark"); }
        }

        /// <summary>
        /// Gets the light navbar color modifier
        /// </summary>
        public static NavbarColor Light
        {
            get { return new NavbarColor("is-light"); }
        }

        /// <summary>
        /// Gets the white navbar color modifier
        /// </summary>
        public static NavbarColor White
        {
            get { return new NavbarColor("is-white"); }
        }

        public NavbarColor(string cssClass)
        {
            _cssClass = string.IsNullOrEmpty(cssClass) ? "is-primary" : cssClass;
        }

        public override string ToString()
        {
            return _cssClass;
        }
    }
}
