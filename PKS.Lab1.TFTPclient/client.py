import os
from tftpy import TftpClient

current_file = os.path.abspath(__file__)
folder_path = os.path.dirname(current_file)

def clear_screen():
    print("\033[H\033[J", end="")

def input_connect():
    ip = input("Введите IP: ")
    port = (int)(input("Введите port: "))

    return (ip, port)

def get_file():
    source = input("Введите имя загружаемого файла: ")
    path = folder_path + '/' + source

    try:
        client.download(source, path)
        print(f"Файл '{source}' загружен успешно.")
    except Exception as e:
        print(f"Ошибка при загрузке: {e}")

def send_file():
    source = input("Введите имя загружаемого файла: ")
    destination = input("Введите имя файла в месте назначения: ")

    if not os.path.exists(source) or not os.path.isfile(source):
        print(f"Файл {source} не существует или не является файлом.")
        return
    
    path = folder_path + '/' + source

    try:
        client.upload(destination, path)
        print("Файл успешно отправлен на сервер")
    except Exception as e:
        print(f"Ошибка при отправке: {e}")

def show_menu():
    while True:
        clear_screen()
        print("1. Загрузить файл")
        print("2. Отправить файл")
        print("q. Выход")

        choice = input("> ")
        print()
        
        match choice:
            case "1":
                get_file()
            case "2":
                send_file()
            case "q":
                print("Закрытие соединения...")
                return
            case _:
                print("Команда не распознана, попробуйте ещё раз.")
        
        print()
        print("Нажмите ENTER, чтобы продолжить...")
        input()
        

if __name__ == "__main__":
    (ip, port) = input_connect()
    try:
        client = TftpClient(ip, port)
    except Exception as e:
        print(f"Ошибка авторизации: {e}")
    show_menu()
