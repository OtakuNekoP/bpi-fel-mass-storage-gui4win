setenv bootargs console=ttyS0,115200 earlycon=uart,mmio32,0x01c28000
booti 0x40080000 0x4fe00000 0x4fa00000
