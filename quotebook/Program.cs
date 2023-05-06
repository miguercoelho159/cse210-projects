// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Board _board = new Board();

_board.AddQuote(new Quote("Paul", " For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.", new Source("2 Timothy 1:7")));
_board.AddQuote(new Quote("Sister Elaine S. Dalton", "Work hard to achieve your dreams. Don’t let discouragement or mistakes delay you.", new Source("How to Dare Great Things", "https://www.churchofjesuschrist.org/study/new-era/2012/03/how-to-dare-great-things?lang=eng")));
_board.AddQuote(new Quote("Alma, the son", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.", new Source("Mosiah 3:19", "https://www.churchofjesuschrist.org/study/scriptures/bofm/mosiah/3?lang=eng")));
_board.AddQuote(new Quote("Alma", "If ye have faith ye hope for things which are not seen, which are true.", new Source("Alma 32:21")));
_board.AddQuote(new Quote("Alma", "Live in Thanksgiving Daily", new Source("Alma 34:38")));
_board.AddQuote(new Quote("Alma", "Counsel with the Lord in all thy doings, and he will direct thee for good", new Source("Alma 37:37")));

// _board.GetRandomQuote();

Menu _menu = new Menu(_board);
_menu.Display();