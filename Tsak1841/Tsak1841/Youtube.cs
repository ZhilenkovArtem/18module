namespace Tsak1841
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    public class Youtube
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнить
        public void StartLoading()
        {
            _command.Run();
        }
    }
}
