# Something_Real
2D-платформер. Unity 5 and C#. Люблю писать код, хочу показать, что умею.
В проекте используются стандартные ассеты Unity и бесплатные ассеты, скачанные с различных источников.

## Инструкция
1. Скачайте этот проект, используя Ваш любимый Git-клиент (Я использую TortoiseGit).
2. Запустите Unity, выберите "File -> Open project...", выберите папку проекта и нажмите кнопку "Select folder".
3. Подождите пару минут – Unity сгенерирует необходимые метаданные.
4. Запустите "File -> Build & Run...", выберите платформу и нажмите кнопку "Build and run".
5. Наслаждайтесь :)

## История изменений

###2016-10-11

####1. Переназначение умений.
Клик мыши по иконке умения сменит умение на следующее из доступных персонажу.

####2. Предметы
Выбор предметов колёсиком мыши или стрелками Влево/Вправо на джойстике.
Использование предметов по колёсику мыши или по кнопке Back на джойстике.
Ключи-карты.
Зелья здоровья (Маленькое, Среднее, Большое).
Применение зелья сопровождается визуальным эффектом.

####3. Двери
Работают как порталы, надо открыть ключом, если закрыта. Находятся в тест-граунде Jumps & Doors.

####4. AI
Небольшая задержка перед атакой.
Во время паузы перед следующей атакой, герой стоит на месте. Далее либо атакует, либо преследует цель.

####5. Камера
Более плавная. Обзор: W/S (стрелки Вверх/Вниз) на клавиатуре или правый стик контроллера.

####6. Меню паузы
Изменилась картинка. Эффект Blur.

####7. Экран загрузки
Статичная картинка во время загрузки уровня.

####8. Умение Slow Motion
Замедление времени. Эффект Twirl во время каста.

###2016-09-27 Первый коммит

#### Краткий обзор
1. 3 уровня, 2 тест-граунда.
2. Игрок может переключаться между доступными персонажами. 
3. У каждого героя разные скорость передвижения, количество прыжков, оружие, атакующие и защитные умения.
4. Враги, управляемые искусственным интеллектом, бродят по уровню.
5. Они будут преследовать и атаковать персонажа игрока, как только он окажется в поле их зрения.
6. Игрок всегда может поставить игру на паузу, перейти в главное меню и загрузить уровень или тестграунд.
7. Устройства ввода: Клавиатура и Мышь, Геймпад (Тестировал на контроллере Xbox360)

####AI (Искусственный интеллект)
1. Герой заметит цель (союзника или врага), когда она окажется в поле его зрения.
2. Каждый герой может быть лидером. Если герой не лидер, он будет искать лидера. Когда лидер найден, герой следует за ним.
3. AI-герой будет использовать атакующие умения, когда враг окажется на дистанции атаки.
4. AI-герой будет использовать защитные навыки, как только его здоровье опустится до критического уровня.