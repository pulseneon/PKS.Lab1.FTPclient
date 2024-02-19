from tftpy import TftpServer

def main():
    server = TftpServer("./server_files/")
    server.listen('0.0.0.0', 5555)

if __name__ == "__main__":
    main()
