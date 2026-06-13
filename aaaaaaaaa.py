import clr

clr.AddReference(r"C:\Users\Inicio\source\repos\utilarq64\bin\Debug\net8.0\utilarq64.dll")


from UtilsArq64 import Arq, Zip, Show, Open, Mem, Vault

Arq.Write("teste.txt", "Olá")

print(Arq.Read("teste.txt"))

Mem.Set("nome", "Gab")
print(Mem.Get("nome"))

Vault.Save("token", "123456")
print(Vault.Read("token"))