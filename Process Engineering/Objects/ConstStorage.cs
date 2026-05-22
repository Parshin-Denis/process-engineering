namespace Process_Engineering
{
    internal class ConstStorage
    {
        public static string[] CARD_TYPES;
        public static string[] PROJECTS;
        public static string[] CARD_CHARACTERS;
        public static string[] ECDV_LIST;
        public static string[] BRANDS;
        public static string[] SECTORS;
        public static string ROLE_CARD_CREATOR = "ROLE_CARD_CREATOR";
        public static string ROLE_ADMIN = "ROLE_ADMIN";
        public static string ROLE_TOOL_CHECKER = "ROLE_TOOL_CHECKER";
        public static string ROLE_EDITOR = "ROLE_EDITOR";
        public static string ROLE_SCREWING_SPECIALIST = "ROLE_SCREWING_SPECIALIST";
        public static string[] ROLE_TYPES = { ROLE_CARD_CREATOR, ROLE_TOOL_CHECKER, ROLE_SCREWING_SPECIALIST, ROLE_EDITOR, ROLE_ADMIN };
        public static string[] SCREWING_TOOL_TYPES = { "Аккумуляторный шуруповерт", "Электронный шуруповерт", "Динамометрический ключ", "Пневматичесчкий шуруповерт" };
        public static int[] BLM_LIST;
        public const string WRONG_USER_PASSWORD = "Неверный логин/пароль";

        public const string TOOL_EDITING = "Редактирование инструмента";
        public const string TOOL_IS_ADDED = "Инструмент добавлен";
        public const string TOOL_IS_UPDATED = "Инструмент изменен";
        public const string ADD_TOOL = "Добавить инструмент {0} ?";
        public const string UPDATE_TOOL = "Изменить данные инструмента с ID {0}?";
        public const string UPDATE_TOOLS = "Изменить данные инструментов с ID {0} и {1}?";
        public const string IMPOSSIBLE_CHANGE_TYPE = "Нельзя изменять тип инструмента";
        public const string IMPOSSIBLE_CHANGE_TOOL = "Нельзя изменять номер инструмента";
        public const string TOOL_IS_NOT_CORRECT = "Инструмент не обеспечивает момент";
        public const string TORQUE_IS_NOT_CONFORM = "Установленный момент не равен моменту в гамме ({0} Н*м)";

        public const string PART_EDITING = "Редактирование деталей";
        public const string PART_IS_ADDED = "Деталь добавлена";
        public const string PART_IS_UPDATED = "Деталь обновлена";
        public const string ADD_PART = "Добавить деталь {0} ?";
        public const string UPDATE_PART = "Изменить данные детали с ID {0}?";

        public const string PITCH_EDITING = "Редактирование постов";
        public const string PITCH_IS_ADDED = "Пост добавлен";
        public const string PITCH_IS_UPDATED = "Пост обновлен";
        public const string ADD_PITCH = "Добавить пост {0} ?";
        public const string UPDATE_PITCH = "Изменить данные поста с ID {0}?";
        public const string PITCH_IS_NOT_CONFORM = "Выбранный пост не соответствует посту гаммы ({0})";

        public const string ADD_ERROR = "Ошибка добавления";
        public const string UPDATE_ERROR = "Ошибка изменения";
        public const string DELETE_ERROR = "Ошибка удаления";
        public const string UNKNOWN_ERROR = "Неизвестная ошибка";
        public const string OPEN_ERROR = "Ошибка открытия";
        public const string SAVE_ERROR = "Ошибка сохранения";

        public const string PAGE_DELETING = "Удаление страницы";
        public const string DELETE_PAGE = "Удалить страницу {0} ?";
        public const string USER_EDITING = "Редактирование пользователей";
        public const string USER_IS_ADDED = "Пользователь добавлен";
        public const string USER_IS_UPDATED = "Пользователь изменен";
        public const string UPDATE_USER = "Изменить данные пользователя с ID {0}?";
        public const string NO_PITCH = "-не задан-";

        public const string PITCH_PUTTING = "Перенос на пост";
        public const string PUT_PITCH = "Перенести гамму на пост {0}?";
        public const string DELETE_PITCH = "Удалить гамму с поста {0}?";

        public const string CAMPAIGN_LOAD = "Загрузка кампаний";
        public const string DISK_NOT_FOUND = "Съемный диск не обнаружен";
        public const string SEVERAL_DISKS = "Обнаружено несколько съемных дисков. \nОставьте только один";
        public const string BLM_NOT_SELECTED = "Необходимо выбрать BLM";
        public const string SECTOR_NOT_SELECTED = "Необходимо выбрать участок проверки";
        public const string TOOL_NOT_SELECTED = "Необходимо выбрать тип инструмента";
        public const string NO_OPEN_CAMPAIGNS = "Нет окрытых кампаний для BLM {0}";
        public const string NO_CAMPAIGN_RESULT = "Не найдено результатов для окрытой кампании на BLM {0}";
        public const string CAMPAIGN_LOADED = "Кампания создана и загружена на диск {0}";
        public const string CAMPAIGN_UPLOADED = "Результаты кампании для BLM {0} загружены";
        public const string START_NEW_CAMPAIGN = "Начать новую кампанию для BLM {0}?";
        public const string DELETE_CAMPAIGN = "Удалить выбранную кампанию?";
        public const string DELETING_CAMPAIGN = "Удаление кампании";        

        public const string CARD_CREATION = "Создание гаммы";
        public const string CREATE_CARD = "Создать новую гамму?";
        public const string CARD_SAVING = "Сохранение гамм";
        public const string CARD_PUTTING_IN_ARCHIVE = "Перемещение гаммы в архив";
        public const string PUT_IN_ARCHIVE = "Вы уверены, что хотите переместить гамму в архив? \nПосле этого она будет не доступна.";
        public const string CARD_RESTORING = "Восстановление гаммы";
        public const string RESTORE_CARD = "Вы уверены, что хотите восстановить гамму из архива?";
        public const string CARDS_PRINTING = "Печать гамм";
        public const string PRINT_CARDS = "Выделено гамм: {0} \nРаспечатать?";
        public const string CARDS_PRINTED = "Гаммы отправлены на печать";
        public const string TOO_MANY_CARDS = "Выбрано гамм: {0} шт. Нельзя отправить на печать больше 50-и гамм.";
        public const string CARD_IS_NOT_ACTUAL = "Гамма удалена в архив";
        public const string CARD_IS_WITHOUT_SCREWING = "В гамме отсутсвует операция завинчивания";

        public const string LABELS_PRINTING = "Печать этикеток'";
        public const string PRINT_LABELS = "Распечатать для выделенных инструментов этикетки?\nВыделено инструментов: {0}";
        public const string LABELS_PRINTED = "Этикетки отправлены на печать";

        public const string SCREWING_TOOL_STATUS = "Статус завинчивающего инструмента";
        public const string ECDV = "Применяемость гаммы";
        public const string BRAND = "Бренд инструмента";
        public const string SECTOR = "Участок";
        public static string CARD_TYPE = "Тип гаммы";
        public static string PROJECT = "Проект";
        public static string CHARACTER = "Характеристика";
        public static string BLM = "BLM";

        public const string EXTRACTION_ERROR = "Ошибка выгрузки";
        public const string APP_NOT_FOUND = "Не найдено необходимое оборудование: ";

        public const string EDIT = "Редактировать";
        public const string ACCEPT_CHANGES = "Принять изменения";
        public const string CARD_IS_NOT_SET = "-не задана-";
        public const string UPDATE = "Обновление данных";
        public const string UPDATED = "Данные обновлены";

        public const string CHANGE_MODE = "Отобразить архивные гаммы?";
        public const string MODE_CHANGING = "Изменение режима просмотра";

    }
}
