import styles from './SobreMim.module.css';

import PostModelo from "componentes/PostModelo"
import fotoCapa from "assets/sobre_mim_capa.png"
import fotoSobreMim from "assets/sobre_mim_foto.png"

export default function SobreMim() {
    return (
        <PostModelo
            fotoCapa={fotoCapa}
            titulo="Sobre mim"
        >
            <h3 className={styles.subtitulo}>
                Olá, eu sou o Lucas!
            </h3>

            <img 
                src={fotoSobreMim}
                alt="Foto do Lucas Araujo"
                className={styles.fotoSobreMim}
            />

            <p className={styles.paragrafo}>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus eu justo ac neque tempor consectetur vitae at risus. Nulla ornare nulla sem, sed vehicula ipsum blandit ut. Fusce mollis egestas massa vitae dapibus. Mauris malesuada vitae mi et cursus. In pharetra ex porttitor dui consectetur finibus. Fusce mi orci, tristique ac convallis sit amet, aliquam eget purus. Curabitur auctor elementum turpis at condimentum.
            </p>
            <p className={styles.paragrafo}>
                Nam suscipit gravida sem sed efficitur. In malesuada eu augue et vulputate. Phasellus ullamcorper vestibulum magna sit amet elementum. Duis at erat massa. Aenean semper viverra neque ac interdum. Donec mattis massa at nunc malesuada, non malesuada mi mattis. Nam scelerisque massa in eros ultrices vulputate. In iaculis condimentum augue sed placerat. Sed facilisis pulvinar nisi. Phasellus purus dolor, iaculis sit amet mollis a, dignissim at turpis. Nulla ex ipsum, pulvinar ac mi in, dignissim commodo tellus. Sed sagittis dignissim dolor vel suscipit. Cras vel dui vitae sapien commodo cursus. Mauris eleifend justo in ex efficitur, quis consectetur mi imperdiet. Quisque finibus urna id bibendum maximus.
            </p>
            <p className={styles.paragrafo}>
                Proin odio diam, tristique eget nunc vel, elementum faucibus enim. Vivamus mattis aliquet turpis, ac ultrices velit egestas ut. Pellentesque eleifend rutrum consequat. Donec blandit nisi sed lorem ultricies lacinia. In blandit quam eu sapien dictum, ac ullamcorper ipsum accumsan. Morbi id ipsum vestibulum, fermentum tortor et, feugiat mi. Nulla luctus egestas leo, at dignissim nunc imperdiet eget. Praesent nulla mi, dictum sed feugiat sed, luctus eu urna. Integer sit amet dui sit amet sem eleifend pulvinar. Fusce ac ipsum iaculis, condimentum lorem a, convallis enim. Donec viverra, est a feugiat dapibus, libero tortor consectetur ligula, ac sollicitudin est sem eu dolor. Sed eleifend sagittis commodo. Nulla mattis dolor ac sapien gravida, ut dignissim urna sollicitudin. Mauris quis accumsan mauris.
            </p>
            <p className={styles.paragrafo}>
                Ut egestas molestie dui, vitae interdum ipsum varius sed. Praesent ultrices porta diam non consequat. Cras eros nunc, iaculis at hendrerit ut, maximus in nisi. Integer tincidunt dictum odio, in gravida est facilisis ut. Donec id justo quis lectus gravida hendrerit sit amet eget ligula. Suspendisse porta dignissim lorem, sed tempor elit pharetra sit amet. Sed aliquet lorem eu mi tincidunt, at dapibus augue ornare.
            </p>
            <p className={styles.paragrafo}>
                Sed neque dolor, aliquet a metus sed, malesuada pretium purus. Nulla nibh ligula, convallis sit amet congue a, vulputate eu libero. Mauris ultricies est ac mauris imperdiet, vitae tempus arcu varius. Cras blandit suscipit arcu, id ornare ligula commodo ut. Suspendisse potenti. Pellentesque rutrum, lorem nec semper tincidunt, nisl metus interdum odio, non euismod nulla diam sed quam. Proin bibendum nunc felis, vel lobortis magna mollis ut. Cras gravida lorem et imperdiet eleifend.
            </p>
        </PostModelo>
    )
}