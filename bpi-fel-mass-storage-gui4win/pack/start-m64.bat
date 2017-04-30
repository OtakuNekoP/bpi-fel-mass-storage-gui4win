@echo off
echo "Connect device in FEL mode and press <Enter>"
pause

set BOARD=m64

win32\sunxi-fel.exe -p spl %BOARD%\spl32.bin write 0x44000 %BOARD%\bl31.bin write 0x4a000000 %BOARD%\u-boot.bin write 0x40080000 %BOARD%\Image write 0x4fa00000 %BOARD%\sun50i-a64-bananapi-m64.dtb write 0x4fc00000 %BOARD%\boot.scr write 0x4fe00000 %BOARD%\initramfs.uimg reset64 0x44000
pause
