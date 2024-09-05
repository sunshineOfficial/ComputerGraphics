namespace ComputerGraphics;

/// <summary>
/// Персонаж Зед
/// </summary>
public class Zed
{
    /// <summary>
    /// Матрица смежности
    /// </summary>
    public List<List<bool>> AdjacencyMatrix { get; set; } = [[false, false, true], [true, false, true]]; // TODO: Подставить матрицу смежности

    /// <summary>
    /// Координаты
    /// </summary>
    public List<List<double>> Coords { get; set; } = [[1, 2, 3], [4, 5, 6]]; // TODO: Подставить координаты

    /// <summary>
    /// Поворот
    /// </summary>
    public void Rotate()
    {
    }

    /// <summary>
    /// Перемещение
    /// </summary>
    public void Move()
    {
    }

    /// <summary>
    /// Масштабировать
    /// </summary>
    public void Scale()
    {
    }

    /// <summary>
    /// Нарисовать
    /// </summary>
    public void Draw()
    {
    }

    /// <summary>
    /// Удалить с экрана
    /// </summary>
    public void Clear()
    {
    }
}