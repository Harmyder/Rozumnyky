import numpy as np
import matplotlib.pyplot as plt


key = 11
alphabet = 'АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ'
step = 0.16
fig, ax = plt.subplots(figsize=(len(alphabet) * step + 1, 4 * step * 2))
ax.set_axis_off()
for k in [(0, 1), (key, 0)]:
    for i in range(0, len(alphabet)):
        curIndex = (i + k[0]) % len(alphabet)
        if (curIndex < key):
            faceColor = (0.8, 0.5, 0.8)
        else:
            faceColor = (0.5, 0.8, 0.8)
        ax.text(0 + i * step, k[1] * step * 4.6, 'Ж', color=faceColor, ha='center', va='center', fontsize=32, bbox=dict(boxstyle="round", ec=faceColor, fc=faceColor), zorder=99)
        ax.text(0 + i * step, k[1] * step * 4.6, alphabet[curIndex], ha='center', va='center', fontsize=32, zorder=100)
#plt.arrow(step / 2, 1 * step * 2, 0, step * 2, width=0.0001)
plt.tight_layout()
plt.savefig(f'..\\..\\Images\\alphabet-key-11.png', bbox_inches='tight', transparent=True)


radius = 1
r = np.repeat(radius, 1000)
theta = np.arange(0, 2 * np.pi, 2 * np.pi / 1000)

step = 2 * np.pi / 10
start = np.pi / 2
for i in np.arange(0, 6):
    fig, ax = plt.subplots(subplot_kw={'projection': 'polar'})
    ax.set_axis_off()
    for x in np.arange(0, 10):
        if -(x) % 10 == (7 + i) % 10:
            ax.text(start + x * step, radius - 0.25, -(x) % 10, ha='center', va='center', fontsize=32, bbox=dict(boxstyle="round", ec=(1., 0.5, 0.5), fc=(1., 0.8, 0.8)))
        else:
            ax.text(start + x * step, radius - 0.25, -(x) % 10, ha='center', va='center', fontsize=32)
    ax.plot(theta, r)
    plt.savefig(f'..\\..\\Images\\{i}.png', bbox_inches='tight', transparent=True)
    plt.close(fig)
