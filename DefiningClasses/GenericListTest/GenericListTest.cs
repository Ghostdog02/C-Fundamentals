using GenericList;

namespace GenericListTest
{
    public class GenericListTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(8)]
        [InlineData(9)]

        public void ReturnElementAt_ValuesBetween0And9Inclusive_ReturnTrue(int index)
        {
            //Arrange
            GenericList<int> list = new(); //Contains 10 elements
            //Act
            var result = list.ReturnElementAt(index);
            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(-1)]

        public void ReturnElementAt_ValuesLessThan0AndBiggerThan9_ReturnFalse(int index)
        {
            //Arrange
            GenericList<int> list = new(); //Contains 10 elements
            //Act and Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.ReturnElementAt(index));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(8, 0)]
        [InlineData(31, 0)]

        public void ReturnElementAt_ValuesBiggerThan0AndLessThan32_ReturnTrue(int index, int expectedValue)
        {
            //Arrange
            GenericList<int> list = new(32);

            //Act
            var result = list.ReturnElementAt(index);

            //Assert
            Assert.Equal(expectedValue, result);
        }


        [Theory]
        [InlineData(-2)]
        [InlineData(-1)]
        [InlineData(33)]

        public void ReturnElementAt_ValuesLessThan0AndBiggerThan32_ReturnFalse(int index)
        {
            //Arrange
            GenericList<int> list = new(32);

            //Act and Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.ReturnElementAt(index));
        }

        [Theory]
        [InlineData(0, 4)]
        [InlineData(1, 5)]
        [InlineData(31, 0)]

        public void ReturnElementAt_ValuesBiggerThan0AndLessThan33_ReturnTrue(int index, int expectedValue)
        {
            //Arrange
            GenericList<int> list = new(33);
            list.AddElement(4);
            list.AddElement(5);

            //Act
            var result = list.ReturnElementAt(index);

            //Assert
            Assert.Equal(expectedValue, result);
        }


        [Theory]
        [InlineData(33)]
        [InlineData(34)]
        [InlineData(-1)]

        public void ReturnElementAt_ValuesLessThan0andBigger32_ReturnFalse(int index)
        {
            //Arrange
            GenericList<int> list = new(32);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);

            //Act and Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.ReturnElementAt(index));
        }

        [Theory]
        [InlineData(32)]
        [InlineData(-1)]

        public void AddElement_EndOfCapacity_ReturnTrue(int element)
        {
            //Arrange
            GenericList<int> list = new(2);
            list.AddElement(element);
            list.AddElement(element);
            list.AddElement(element);

            //Act
            var result = list.ReturnElementAt(2);

            //Assert
            Assert.Equal(element, result);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(1, 6)]
        [InlineData(2, -1)]

        public void RemoveElementAt_ValuesBiggerThan0AndLessThan33_ReturnTrue(int index, int expectedValue)
        {
            //Arrange
            GenericList<int> list = new(4);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);
            list.AddElement(-1);

            //Act
            var count = list.Count;
            list.RemoveElementAt(index);

            //Assert
            if (index == count - 1)
                Assert.Equal(expectedValue, list.ReturnElementAt(index - 1));
            else
                Assert.Equal(expectedValue, list.ReturnElementAt(index));

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 2)]

        public void RemoveElementAt_ValuesForRemovedIndex2OrBigger_ReturnFalse(int index, int removedIndex)
        {
            //Arrange
            GenericList<int> list = new(3);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);

            //Act
            list.RemoveElementAt(index);

            //Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.ReturnElementAt(removedIndex));
        }

        [Theory]
        [InlineData(1, 2, 3, 9, 2, 9)]
        [InlineData(2, 3, 3, 8, 1, 8)]
        [InlineData(3, 5, 4, 14, 0, 14)]

        public void InsertAt_ValuesForIndexBiggerThan0AndLessThan3_ReturnTrue(int element1, int element2, int element3,
            int replacedElement, int index, int expectedValue)
        {
            //Arrange
            GenericList<int> list = new GenericList<int>(3);
            list.AddElement(element1);
            list.AddElement(element2);
            list.AddElement(element3);

            //Act
            list.InsertAt(replacedElement, index);

            //Assert
            Assert.Equal(expectedValue, list.ReturnElementAt(index));

        }

        [Theory]
        [InlineData(1, 2, 3, 15, 3, 1)]
        [InlineData(6, 2, 3, 9, 2, 6)]
        [InlineData(2, 3, 3, 8, 1, 2)]
        [InlineData(3, 5, 4, 14, 0, 3)]

        public void InsertAt_ValuesForIndexBiggerThan0AndLessThan4_ReturnTrue(int element1, int element2, int element3,
            int replacedElement, int index, int expectedValue)
        {
            //Arrange
            GenericList<int> list = new GenericList<int>(4);
            list.AddElement(element1);
            list.AddElement(element2);
            list.AddElement(element3);
            list.AddElement(element1);

            //Act
            list.InsertAt(replacedElement, index);

            //Assert
            Assert.Equal(expectedValue, list[4]);

        }

        [Theory]
        [InlineData(0, 4)]
        [InlineData(1, 5)]
        [InlineData(2, 6)]

        public void Indexer_ValuesBiggerThan0AndLessThan3_ReturnTrue(int index, int expectedValue)
        {
            //Arrange
            var list = new GenericList<int>(3);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);

            //Act
            var element = list[index];

            //Assert
            Assert.Equal(expectedValue, element);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(3)]
        [InlineData(4)]

        public void Indexer_ValuesLessThan0AndEqualTo3OrBigger_ReturnFalse(int index)
        {
            //Arrange
            var list = new GenericList<int>(3);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);

            //Act and Assert
            Assert.Throws<IndexOutOfRangeException>(() => list[index]);
        }

        [Fact]
        public void Clear_EmptyArray_ReturnTrue()
        {
            //Arrange
            var list = new GenericList<int>(0);

            //Act
            list.Clear();

            //Assert
            Assert.Equal(0, list.Count);
        }

        [Fact]

        public void Clear_IntArrayWith3Elements_ReturnTrue()
        {
            //Arrange
            var list = new GenericList<int>(3);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);

            //Act
            list.Clear();

            //Assert
            Assert.Equal(0, list.Count);
        }

        [Theory]
        [InlineData("example", 0)]
        [InlineData("test", 1)]
        [InlineData("exercise", 2)]

        public void IndexOf_StringArrayWith3Matches_ReturnTrue(string elementToFind, int expectedIndex)
        {
            //Arrange
            var list = new GenericList<string>(3);
            list.AddElement("example");
            list.AddElement("test");
            list.AddElement("exercise");

            //Act
            var index = list.IndexOf(elementToFind);

            //Assert
            Assert.Equal(expectedIndex, index);
        }

        [Theory]
        [InlineData("fsdfs", -1)]
        [InlineData("fsfsdfs", -1)]
        [InlineData("sfdfs", -1)]

        public void IndexOf_StringArrayWith0Matches_ReturnFalse(string elementToFind, int expectedIndex)
        {
            //Arrange
            var list = new GenericList<string>(3);
            list.AddElement("example");
            list.AddElement("test");
            list.AddElement("exercise");

            //Act
            var index = list.IndexOf(elementToFind);

            //Assert
            Assert.Equal(expectedIndex, index);
        }

        [Fact]

        public void ToString_IntArrayWith3Elements_ReturnTrue()
        {
            //Arrange
            var list = new GenericList<int>(3);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);

            //Act
            var output = list.ToString();

            //Assert
            Assert.Equal("456", output);
        }       
    }
}