# mkimage -C none -A arm -T script -d boot.cmd boot.scr

sudo ./sunxi-fel -p \
	spl spl32.bin \
	write 0x44000 bl31.bin \
	write 0x4a000000 u-boot.bin \
	write 0x40080000 Image \
	write 0x4fa00000 sun50i-a64-bananapi-m64.dtb \
	write 0x4fc00000 boot.scr \
	write 0x4fe00000 initramfs.uimg \
	reset64 0x44000
