using Program;

namespace Program.Tests
{
    public class DynamicStackConstructorTest
    {
        [Fact]

        public void Constructor_EmptyStack_InitializePropertyWithNull()
        {
            //Arrange and Act
            DynamicStack stack = new DynamicStack();

            //Assert
            Assert.Null(stack.Top);
            Assert.Equal(0, stack.Count);
        }
    }
}