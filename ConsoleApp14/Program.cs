// Размер особняка
const int MansionSize = 5;

// Типы комнат
const int Empty = 0; //пустая
const int Clue = 1; //ключ
const int Locked = 2; //закрытая
const int Puzzle = 3; //комната с загадкой
const int Final = 4; //финал

int[,] mansionMap = new int[MansionSize, MansionSize];

