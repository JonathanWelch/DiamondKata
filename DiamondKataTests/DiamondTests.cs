using DiamondKata;

namespace DiamondKataTests
{
    [TestFixture]
    public class DiamondTests
    {
        private Diamond _diamond;

        [SetUp]
        public void Setup()
        {
            _diamond = new Diamond();
        }

        [TestCase('A')]
        [TestCase('a')]
        public void CanCreateA(char letter)
        {
            var diamond = _diamond.Create(letter);

            Assert.That(diamond, Is.EqualTo("A"));
        }

        [TestCase('B')]
        [TestCase('b')]
        public void CanCreateB(char letter)
        {
            var diamond = _diamond.Create(letter);

            const string expectedDiamond = " A \r\n" +
                                           "B B\r\n" +
                                           " A \r\n";

            Assert.That(diamond, Is.EqualTo(expectedDiamond));
        }

        [TestCase('C')]
        [TestCase('c')]
        public void CanCreateC(char letter)
        {
            var diamond = _diamond.Create(letter);

            const string expectedDiamond = "  A  \r\n" +
                                           " B B \r\n" +
                                           "C   C\r\n" +
                                           " B B \r\n" +
                                           "  A  \r\n";

            Assert.That(diamond, Is.EqualTo(expectedDiamond));
        }

        [TestCase('d')]
        [TestCase('D')]
        public void CanCreateD(char letter)
        {
            var diamond = _diamond.Create(letter);

            const string expectedDiamond = "   A   \r\n" +
                                           "  B B  \r\n" +
                                           " C   C \r\n" +
                                           "D     D\r\n" +
                                           " C   C \r\n" +
                                           "  B B  \r\n" +
                                           "   A   \r\n";

            Assert.That(diamond, Is.EqualTo(expectedDiamond));
        }

        [TestCase('z')]
        [TestCase('Z')]
        public void CanPrintZ(char letter)
        {
            var diamond = _diamond.Create(letter);

            const string expectedDiamond = "                         A                         \r\n" +
                                           "                        B B                        \r\n" +
                                           "                       C   C                       \r\n" +
                                           "                      D     D                      \r\n" +
                                           "                     E       E                     \r\n" +
                                           "                    F         F                    \r\n" +
                                           "                   G           G                   \r\n" +
                                           "                  H             H                  \r\n" +
                                           "                 I               I                 \r\n" +
                                           "                J                 J                \r\n" +
                                           "               K                   K               \r\n" +
                                           "              L                     L              \r\n" +
                                           "             M                       M             \r\n" +
                                           "            N                         N            \r\n" +
                                           "           O                           O           \r\n" +
                                           "          P                             P          \r\n" +
                                           "         Q                               Q         \r\n" +
                                           "        R                                 R        \r\n" +
                                           "       S                                   S       \r\n" +
                                           "      T                                     T      \r\n" +
                                           "     U                                       U     \r\n" +
                                           "    V                                         V    \r\n" +
                                           "   W                                           W   \r\n" +
                                           "  X                                             X  \r\n" +
                                           " Y                                               Y \r\n" +
                                           "Z                                                 Z\r\n" +
                                           " Y                                               Y \r\n" +
                                           "  X                                             X  \r\n" +
                                           "   W                                           W   \r\n" +
                                           "    V                                         V    \r\n" +
                                           "     U                                       U     \r\n" +
                                           "      T                                     T      \r\n" +
                                           "       S                                   S       \r\n" +
                                           "        R                                 R        \r\n" +
                                           "         Q                               Q         \r\n" +
                                           "          P                             P          \r\n" +
                                           "           O                           O           \r\n" +
                                           "            N                         N            \r\n" +
                                           "             M                       M             \r\n" +
                                           "              L                     L              \r\n" +
                                           "               K                   K               \r\n" +
                                           "                J                 J                \r\n" +
                                           "                 I               I                 \r\n" +
                                           "                  H             H                  \r\n" +
                                           "                   G           G                   \r\n" +
                                           "                    F         F                    \r\n" +
                                           "                     E       E                     \r\n" +
                                           "                      D     D                      \r\n" +
                                           "                       C   C                       \r\n" +
                                           "                        B B                        \r\n" +
                                           "                         A                         \r\n";


            Assert.That(diamond, Is.EqualTo(expectedDiamond));
        }

        [TestCase('0')]
        [TestCase('1')]
        [TestCase('2')]
        [TestCase('3')]
        [TestCase('4')]
        [TestCase('5')]
        [TestCase('6')]
        [TestCase('7')]
        [TestCase('8')]
        [TestCase('9')]
        public void CanHandleInvalidNumber(char letter)
        {
            var diamond = _diamond.Create(letter);

            Assert.That(diamond, Is.EqualTo("Invalid letter inputted."));
        }

        [TestCase('!')]
        [TestCase('£')]
        [TestCase('$')]
        [TestCase('%')]
        [TestCase('^')]
        [TestCase('&')]
        [TestCase('*')]
        [TestCase('(')]
        [TestCase(')')]
        [TestCase('_')]
        public void CanHandleInvalidCharacter(char letter)
        {
            var diamond = _diamond.Create(letter);

            Assert.That(diamond, Is.EqualTo("Invalid letter inputted."));
        }
    }
}