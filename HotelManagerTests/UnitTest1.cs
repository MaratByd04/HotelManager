using Sem_2_Lesson_4_;

namespace HotelManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        private HotelManager hotelForm; // �������� YourFormName �� �������� ��� ����� �����

        [TestInitialize]
        public void Initialize()
        {
            hotelForm = new HotelManager(); // ������� ��������� ����� ��� ������������
        }

        [TestMethod]
        public void TestGuestListUpdateForRegistered()
        {
            // Arrange
            string[,] infoAboutGuests = new string[2, 4]; // ������ ������ � ������
            infoAboutGuests[0, 1] = "����� �������";
            infoAboutGuests[0, 3] = "��������������";
            infoAboutGuests[1, 1] = "���� ��������";
            infoAboutGuests[1, 3] = "�� ��������������";
            hotelForm.infoAboutGuests = infoAboutGuests; // �������� ������ � ������ � �����
            hotelForm.peopleAmount = 2; // ������������� ���������� ������

            // Act
            hotelForm.registeredRadioButton.Checked = true; // �������� ����� "������������������"
            hotelForm.registeredRadioButton_CheckedChanged(null, EventArgs.Empty); // �������� ����� ����������

            // Assert
            Assert.AreEqual(1, hotelForm.guestsListBox.Items.Count); // ��������� ���������� ��������� � ������
            Assert.AreEqual("John Doe", hotelForm.guestsListBox.Items[0]); // ���������, ��� ���������� ����� �������� � ������
        }
    }
}