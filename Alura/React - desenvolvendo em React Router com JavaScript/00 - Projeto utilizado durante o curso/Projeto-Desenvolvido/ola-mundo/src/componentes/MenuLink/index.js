import { NavLink } from 'react-router-dom'
import styles from './MenuLink.module.css'

export default function MenuLink({ children, to }) {
    return (
        <NavLink 
            className={({ isActive }) => `
                ${styles.link}
                ${isActive ? styles.linkDestacado : ""}
            `}
            to={to}
            end
        >
            {children}
        </NavLink>
    )
}

// Versão com o elemento Link e useLocation()
// export default function MenuLink({ children, to }) {
//     const localizacao = useLocation();

//     return (
//         <Link className={`
//             ${styles.link}
//             ${localizacao.pathname === to ? styles.linkDestacado : ''}
//         `} to={to}>
//             {children}
//         </Link>
//     )
// }