using Sem_2_Lesson_4_;

namespace HotelManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        private HotelManager hotelForm; // Замените YourFormName на реальное имя вашей формы

        [TestInitialize]
        public void Initialize()
        {
            hotelForm = new HotelManager(); // Создаем экземпляр формы для тестирования
        }

        [TestMethod]
        public void TestGuestListUpdateForRegistered()
        {
            // Arrange
            string[,] infoAboutGuests = new string[2, 4]; // Пример данных о гостях
            infoAboutGuests[0, 1] = "Карим Бакиров";
            infoAboutGuests[0, 3] = "зарезервировал";
            infoAboutGuests[1, 1] = "Егор Шабардин";
            infoAboutGuests[1, 3] = "не зарезервировал";
            hotelForm.infoAboutGuests = infoAboutGuests; // Передаем данные о гостях в форму
            hotelForm.peopleAmount = 2; // Устанавливаем количество гостей

            // Act
            hotelForm.registeredRadioButton.Checked = true; // Выбираем опцию "зарегистрированные"
            hotelForm.registeredRadioButton_CheckedChanged(null, EventArgs.Empty); // Вызываем метод обработчик

            // Assert
            Assert.AreEqual(1, hotelForm.guestsListBox.Items.Count); // Проверяем количество элементов в списке
            Assert.AreEqual("John Doe", hotelForm.guestsListBox.Items[0]); // Проверяем, что правильный гость добавлен в список
        }
    }
}